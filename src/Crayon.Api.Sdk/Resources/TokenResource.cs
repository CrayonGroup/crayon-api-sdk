using Crayon.Api.Sdk.Domain.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace Crayon.Api.Sdk.Resources
{
    public class TokenResource
    {
        private static readonly IEnumerable<string> DefaultScopes;
        private readonly CrayonApiClient _client;

        static TokenResource()
        {
            DefaultScopes = new List<string> {
                "CustomerApi"
            };
        }

        public TokenResource(CrayonApiClient client)
        {
            _client = client;
        }

        public CrayonApiClientDataResult<Token> GetUserToken(string clientId, string clientSecret, string userName, string password)
        {
            return GetUserToken(clientId, clientSecret, userName, password, DefaultScopes);
        }

        public CrayonApiClientDataResult<Token> GetUserToken(string clientId, string clientSecret, string userName, string password, IEnumerable<string> scopes)
        {
            if (scopes == null)
            {
                scopes = Enumerable.Empty<string>();
            }

            var request = SetupAuthenticationRequest(clientId, clientSecret, userName, password, scopes);
            var response = _client.SendRequest(request);

            return _client.DeserializeResponseToResultOf<Token>(response);
        }

        private static HttpRequestMessage SetupAuthenticationRequest(string clientId, string clientSecret, string userName, string password, IEnumerable<string> scopes)
        {
            var uri = "api/v1/connect/token";
            var authHeaderBytes = Encoding.UTF8.GetBytes($"{clientId}:{clientSecret}");
            var basicAuthentication = Convert.ToBase64String(authHeaderBytes);

            var joinedScopes = string.Join(" ", scopes);

            userName = WebUtility.UrlEncode(userName);
            password = WebUtility.UrlEncode(password);
            joinedScopes = WebUtility.UrlEncode(joinedScopes);

            var requestPayload = $"grant_type=password&username={userName}&password={password}&scope={joinedScopes}";
            var request = new HttpRequestMessage(HttpMethod.Post, uri) {
                Content = new StringContent(requestPayload)
            };

            request.Content.Headers.ContentType = new MediaTypeHeaderValue("application/x-www-form-urlencoded");
            request.Headers.Authorization = new AuthenticationHeaderValue("Basic", basicAuthentication);

            return request;
        }
    }
}