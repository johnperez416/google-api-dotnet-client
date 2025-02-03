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

using Google.Apis.Http;
using System.Collections.Generic;
using System.Net.Http;

namespace Google.Apis.Tests.Mocks
{
    /// <summary>
    /// Mock HTTP client factory which gets a specific message handler (for mocking) and use for creating the HTTP
    /// client.
    /// </summary>
    public class MockHttpClientFactory : HttpClientFactory
    {
        private readonly List<CreateHttpClientArgs> _args = new List<CreateHttpClientArgs>();
        private HttpMessageHandler Handler { get; set; }
        public IEnumerable<CreateHttpClientArgs> AllCreateHttpClientArgs => _args;

        public MockHttpClientFactory(HttpMessageHandler handler)
        {
            Handler = handler;
        }

        protected override HttpMessageHandler CreateHandler(CreateHttpClientArgs args)
        {
            _args.Add(args);
            return Handler;
        }
    }
}
