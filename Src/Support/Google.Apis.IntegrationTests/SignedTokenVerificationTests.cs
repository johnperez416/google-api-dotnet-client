﻿/*
Copyright 2020 Google Inc

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

using Google.Apis.Auth.OAuth2;
using System;
using System.Security.Cryptography;
using System.Threading.Tasks;
using Xunit;
using static Google.Apis.Auth.SignedTokenVerification;

namespace IntegrationTests
{
    public class SignedTokenVerificationTests
    {
        [Theory]
        [InlineData(GoogleAuthConsts.JsonWebKeySetUrl)]
        [InlineData("https://www.googleapis.com/service_accounts/v1/jwk/chat@system.gserviceaccount.com")]
        public async Task CertificateCache_JWK_RS256(string certificateLocation)
        {
            var certCache = new CertificateCache();

            var certificates = await certCache.GetCertificatesAsync(certificateLocation, FromKeyToRsa, false, default);

            Assert.NotEmpty(certificates);
        }

        [Fact]
        public async Task CertificateCache_NonJWK_Error()
        {
            var certCache = new CertificateCache();

            var exception = await Assert.ThrowsAsync<ArgumentException>(() => certCache.GetCertificatesAsync(
                "https://www.googleapis.com/service_accounts/v1/metadata/x509/chat@system.gserviceaccount.com", json => RSA.Create(), false, default));
            Assert.Contains("Only JWK formatted keys are currently supported", exception.Message);
        }
    }
}
