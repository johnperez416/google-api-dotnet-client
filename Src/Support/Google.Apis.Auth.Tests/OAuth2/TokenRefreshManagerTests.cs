﻿/*
Copyright 2018 Google LLC

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    https://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/

using Google.Apis.Auth.OAuth2;
using Google.Apis.Auth.OAuth2.Responses;
using Google.Apis.Logging;
using Google.Apis.Tests.Mocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Google.Apis.Auth.Tests.OAuth2
{
    public class TokenRefreshManagerTests
    {
        public int TokenResponseMan { get; private set; }

        [Theory, CombinatorialData]
        public async Task SingleTokenConcurrentRefresh(
            [CombinatorialValues(1, 2, 3, 6, 11)] int concurrentRefreshCount)
        {
            // Test multiple refreshes concurrently and sequentially,
            // where all refreshes return the same token.
            var clock = new MockClock(new DateTime(2010, 1, 1, 0, 0, 0, DateTimeKind.Utc));
            var logger = new NullLogger();
            int refreshFnCount = 0;
            TaskCompletionSource<int> delayTask = null;
            TokenRefreshManager trm = null;
            trm = new TokenRefreshManager(async ct =>
            {
                await delayTask.Task;
                trm.Token = new TokenResponse
                {
                    AccessToken = "AccessToken1",
                    ExpiresInSeconds = TokenResponse.TokenRefreshWindowSeconds * 2 + 1,
                    IssuedUtc = clock.UtcNow
                };
                Interlocked.Increment(ref refreshFnCount);
                return true;
            }, clock, logger);

            for (int iteration = 0; iteration < 3; iteration++)
            {
                delayTask = new TaskCompletionSource<int>();
                var tokenTasks = new Task<string>[concurrentRefreshCount];
                for (int i = 0; i < concurrentRefreshCount; i++)
                {
                    tokenTasks[i] = trm.GetAccessTokenForRequestAsync(CancellationToken.None);
                }
                delayTask.SetResult(0);
                var tokens = await Task.WhenAll(tokenTasks);

                foreach (var token in tokens)
                {
                    Assert.Equal("AccessToken1", token);
                }

                clock.UtcNow += TimeSpan.FromMinutes(1);
            }
            Assert.Equal(1, refreshFnCount);
        }

        [Theory, CombinatorialData]
        public async Task MultipleInvalidTokensTokensConcurrentRefreshes(
            [CombinatorialValues(1, 2, 3, 6, 11)] int concurrentRefreshCount)
        {
            // Test multiple refreshes concurrently and sequentially,
            // where the sequential refreshes are after the previous token has completely expired.
            var clock = new MockClock(new DateTime(2010, 1, 1, 0, 0, 0, DateTimeKind.Utc));
            var logger = new NullLogger();
            int refreshFnCount = 0;
            TaskCompletionSource<int> delayTask = null;
            string accessToken = null;
            TokenRefreshManager trm = null;
            trm = new TokenRefreshManager(async ct =>
            {
                await delayTask.Task;
                trm.Token = new TokenResponse
                {
                    AccessToken = Interlocked.Exchange(ref accessToken, accessToken),
                    ExpiresInSeconds = TokenResponse.TokenRefreshWindowSeconds + 1,
                    IssuedUtc = clock.UtcNow
                };
                Interlocked.Increment(ref refreshFnCount);
                return true;
            }, clock, logger);

            for (int iteration = 0; iteration < 5; iteration++)
            {
                delayTask = new TaskCompletionSource<int>();
                Interlocked.Exchange(ref accessToken, $"AccessToken{iteration}");
                var tokenTasks = new Task<string>[concurrentRefreshCount];
                for (int i = 0; i < concurrentRefreshCount; i++)
                {
                    tokenTasks[i] = trm.GetAccessTokenForRequestAsync(CancellationToken.None);
                }
                delayTask.SetResult(0);
                var tokens = await Task.WhenAll(tokenTasks);

                foreach (var token in tokens)
                {
                    Assert.Equal(accessToken, token);
                }

                clock.UtcNow += TimeSpan.FromHours(24);
            }
            Assert.Equal(5, Interlocked.Add(ref refreshFnCount, 0));
        }

        [Theory, CombinatorialData]
        public async Task MultipleSoftExpiredTokensConcurrentRefreshes(
            [CombinatorialValues(1, 2, 3, 6, 11)] int concurrentRefreshCount,
            [CombinatorialValues(3, 5, 10)] int refreshIterations)
        {
            // Test multiple refreshes concurrently and sequentially,
            // where the sequential refreshes are after the previous token has completely expired.
            var clock = new MockClock(new DateTime(2010, 1, 1, 0, 0, 0, DateTimeKind.Utc));
            var logger = new NullLogger();
            TaskCompletionSource<int> delayTask = null;
            TokenRefreshManager trm = null;
            trm = new TokenRefreshManager(async ct =>
            {
                await Interlocked.CompareExchange(ref delayTask, null, null).Task;
                var utcNow = clock.UtcNow;
                trm.Token = new TokenResponse
                {
                    AccessToken = utcNow.ToString("O"),
                    // Needs refresh on the iteration after the one it was issued in.
                    // Becomes invalid on the second iteration after the one it was issued in.
                    ExpiresInSeconds = TokenResponse.TokenRefreshWindowSeconds + 1,
                    IssuedUtc = utcNow
                };
                return true;
            }, clock, logger);

            HashSet<string> distinctTokens = new HashSet<string>();
            for (int iteration = 0; iteration < refreshIterations; iteration++)
            {
                clock.UtcNow += TimeSpan.FromSeconds(TokenResponse.TokenRefreshWindowSeconds - TokenResponse.TokenInvalidWindowSeconds);

                Interlocked.Exchange(ref delayTask, new TaskCompletionSource<int>());
                var tokenTasks = new Task<string>[concurrentRefreshCount];
                for (int i = 0; i < concurrentRefreshCount; i++)
                {
                    tokenTasks[i] = trm.GetAccessTokenForRequestAsync(CancellationToken.None);
                }
                Interlocked.CompareExchange(ref delayTask, null, null).SetResult(0);
                var tokens = await Task.WhenAll(tokenTasks);

                // We cannot be certain that all the tokens obtained during an iteration
                // are the same. The refresh task started on a previous iteration may
                // finish during this one, as we don't wait for refresh tasks to be done
                // before starting a new iteration.
                foreach (var token in tokens)
                {
                    distinctTokens.Add(token);
                }
            }
            // But, because the tokens should be refreshed on the next iteration they are issued
            // and and stop being valid 2 iterations after they are issued, we know that we at least
            // get iterations / 2 distinct tokens.
            Assert.InRange(distinctTokens.Count, refreshIterations / 2, refreshIterations);
        }

        [Fact]
        public async Task ExpiredToken()
        {
            var clock = new MockClock(new DateTime(2010, 1, 1, 0, 0, 0, DateTimeKind.Utc));
            var logger = new NullLogger();
            int refreshFnCount = 0;
            string accessToken = null;
            TokenRefreshManager trm = null;
            trm = new TokenRefreshManager(ct =>
            {
                trm.Token = new TokenResponse
                {
                    AccessToken = accessToken,
                    ExpiresInSeconds = 60 * 60,
                    IssuedUtc = clock.UtcNow
                };
                Interlocked.Increment(ref refreshFnCount);
                return Task.FromResult(true);
            }, clock, logger);

            accessToken = "AccessToken1";
            var accessToken1 = await trm.GetAccessTokenForRequestAsync(CancellationToken.None);
            clock.UtcNow += TimeSpan.FromHours(24);
            accessToken = "AccessToken2";
            var accessToken2 = await trm.GetAccessTokenForRequestAsync(CancellationToken.None);

            Assert.Equal(2, Interlocked.Add(ref refreshFnCount, 0));
            Assert.Equal("AccessToken1", accessToken1);
            Assert.Equal("AccessToken2", accessToken2);
        }

        [Fact]
        public async Task CancelDuringRefresh()
        {
            var clock = new MockClock(new DateTime(2010, 1, 1, 0, 0, 0, DateTimeKind.Utc));
            var logger = new NullLogger();
            int refreshCalled = 0;
            int refreshCompleted = 0;
            var refreshCts = new CancellationTokenSource();
            TokenRefreshManager trm = null;
            trm = new TokenRefreshManager(async ct =>
            {
                Interlocked.Increment(ref refreshCalled);
                await Task.Delay(TimeSpan.FromSeconds(60), refreshCts.Token);
                // Will never get here
                Interlocked.Increment(ref refreshCompleted);
                return false;
            }, clock, logger);

            var cts = new CancellationTokenSource(TimeSpan.FromMilliseconds(10));
            await Assert.ThrowsAsync<TaskCanceledException>(() => trm.GetAccessTokenForRequestAsync(cts.Token));
            refreshCts.Cancel();
            
            // Non-deterministic if the refresh function gets called by the time this test ends.
            // And it's either be called never, or retried n times by the token refresh manager.
            Assert.InRange(Interlocked.Add(ref refreshCalled, 0), 0, TokenRefreshManager.RefreshTimeouts.Length);
            Assert.Equal(0, Interlocked.Add(ref refreshCompleted, 0));
        }

        [Fact]
        public async Task RetriesTimeout_Sync()
        {
            var clock = new MockClock(new DateTime(2010, 1, 1, 0, 0, 0, DateTimeKind.Utc));
            var logger = new NullLogger();
            int refreshCallCount = 0;
            int refreshCompleted = 0;
            TokenRefreshManager trm = null;
            trm = new TokenRefreshManager(ct =>
            {
                Interlocked.Increment(ref refreshCallCount);
                Assert.True(ct.CanBeCanceled);
                new CancellationToken(true).ThrowIfCancellationRequested();
                // Will never get here
                Interlocked.Increment(ref refreshCompleted);
                return Task.FromResult(false);
            }, clock, logger);

            var ex = await Assert.ThrowsAsync<InvalidOperationException>(() => trm.GetAccessTokenForRequestAsync(CancellationToken.None));
            Assert.Contains("timeout, timeout, timeout", ex.Message);
            Assert.Equal(TokenRefreshManager.RefreshTimeouts.Length, refreshCallCount);
            Assert.Equal(0, Interlocked.Add(ref refreshCompleted, 0));
        }

        [Fact]
        public async Task RetriesTimeout_Async()
        {
            var clock = new MockClock(new DateTime(2010, 1, 1, 0, 0, 0, DateTimeKind.Utc));
            var logger = new NullLogger();
            int refreshCallCount = 0;
            int refreshCompleted = 0;
            TokenRefreshManager trm = null;
            trm = new TokenRefreshManager(async ct =>
            {
                Interlocked.Increment(ref refreshCallCount);
                Assert.True(ct.CanBeCanceled);
                var token = new CancellationTokenSource(TimeSpan.FromMilliseconds(10)).Token;
                await Task.Delay(TimeSpan.FromSeconds(10), token);
                // Will never get here
                Interlocked.Increment(ref refreshCompleted);
                return false;
            }, clock, logger);

            var ex = await Assert.ThrowsAsync<InvalidOperationException>(() => trm.GetAccessTokenForRequestAsync(CancellationToken.None));
            Assert.Contains("timeout, timeout, timeout", ex.Message);
            Assert.Equal(TokenRefreshManager.RefreshTimeouts.Length, refreshCallCount);
            Assert.Equal(0, Interlocked.Add(ref refreshCompleted, 0));
        }

        [Fact]
        public async Task RetriesError_Sync()
        {
            var clock = new MockClock(new DateTime(2010, 1, 1, 0, 0, 0, DateTimeKind.Utc));
            var logger = new NullLogger();
            int refreshCallCount = 0;
            int refreshCompleted = 0;
            TokenRefreshManager trm = null;
            trm = new TokenRefreshManager(ct =>
            {
                Interlocked.Increment(ref refreshCallCount);
                return Task.FromResult(false);
            }, clock, logger);

            var ex = await Assert.ThrowsAsync<InvalidOperationException>(() => trm.GetAccessTokenForRequestAsync(CancellationToken.None));
            Assert.Contains("refresh error, refresh error, refresh error", ex.Message);
            Assert.Equal(TokenRefreshManager.RefreshTimeouts.Length, refreshCallCount);
            Assert.Equal(0, Interlocked.Add(ref refreshCompleted, 0));
        }

        [Fact]
        public async Task RetriesError_Async()
        {
            var clock = new MockClock(new DateTime(2010, 1, 1, 0, 0, 0, DateTimeKind.Utc));
            var logger = new NullLogger();
            int refreshCallCount = 0;
            int refreshCompleted = 0;
            TokenRefreshManager trm = null;
            trm = new TokenRefreshManager(async ct =>
            {
                Interlocked.Increment(ref refreshCallCount);
                await Task.Yield();
                return false;
            }, clock, logger);

            var ex = await Assert.ThrowsAsync<InvalidOperationException>(() => trm.GetAccessTokenForRequestAsync(CancellationToken.None));
            Assert.Contains("refresh error, refresh error, refresh error", ex.Message);
            Assert.Equal(TokenRefreshManager.RefreshTimeouts.Length, refreshCallCount);
            Assert.Equal(0, Interlocked.Add(ref refreshCompleted, 0));
        }

        [Fact]
        public async Task UnobservedException()
        {
            // An unobserved exception used to happen if a token refresh task is started
            // but not inmediately observed and it fails.
            // See https://github.com/googleapis/google-api-dotnet-client/issues/2021
            string exceptionMessage = "While testing for unobserved exceptions the refresh task failed.";
            int unobservedCount = 0;
            TaskScheduler.UnobservedTaskException += (sender, e) =>
            {
                if (e.Exception.InnerExceptions.Any(ex => ex.Message == exceptionMessage))
                {
                    Interlocked.Increment(ref unobservedCount);
                    e.SetObserved();
                }
            };

            var refreshCompletionSource = new TaskCompletionSource<bool>();
            var clock = new MockClock(new DateTime(2010, 1, 1, 0, 0, 0, DateTimeKind.Utc));
            var logger = new NullLogger();
            var utcNow = clock.UtcNow;
            var shouldRefreshToken = new TokenResponse
            {
                AccessToken = utcNow.ToString("O"),
                ExpiresInSeconds = TokenResponse.TokenRefreshWindowSeconds,
                IssuedUtc = utcNow
            };
            TokenRefreshManager trm = new TokenRefreshManager(ThrowsWhenRefreshing, clock, logger)
            {
                // The initial token should be refreshed.
                Token = shouldRefreshToken
            };

            // Since the token should be refreshed but it's still valid, we will get it, but a refresh task
            // will be started.
            var token = await trm.GetAccessTokenForRequestAsync(default);
            Assert.Equal(shouldRefreshToken.AccessToken, token);

            // Let's wait for refresh to be done, so that we know for certain that an exception has been thrown.
            await refreshCompletionSource.Task;

            trm = null;
            GC.Collect();
            GC.WaitForPendingFinalizers();

            // And let's just wait a little bit more, just to make sure that the UnobservedException would be raised.
            await Task.Delay(TimeSpan.FromSeconds(5));

            // We should not see unobserved exceptions as we are guarding against that.
            Assert.Equal(0, unobservedCount);

            async Task<bool> ThrowsWhenRefreshing(CancellationToken ct)
            {
                try
                {
                    // Let's yeild so that we don't complete syncronously.
                    await Task.Yield();
                    throw new Exception(exceptionMessage);
                }
                finally
                {
                    refreshCompletionSource.SetResult(true);
                }
            }
        }
    }
}
