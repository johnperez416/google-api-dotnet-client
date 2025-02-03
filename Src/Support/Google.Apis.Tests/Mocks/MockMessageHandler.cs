﻿/*
Copyright 2017 Google Inc

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/

using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Apis.Tests.Mocks
{
    /// <summary>A mock of <see cref="HttpMessageHandler"/> that records the content of an incoming request.</summary>
    class MockMessageHandler : HttpMessageHandler
    {
        public string RequestContent { get; set; }

        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request,
            CancellationToken cancellationToken)
        {
            // TODO: Investigate making this async. The fact that this returns a null *task*
            // at the moment (not a task with a null result) is alarming.
            RequestContent = request.Content.ReadAsStringAsync().Result;
            return null;
        }
    }
}
