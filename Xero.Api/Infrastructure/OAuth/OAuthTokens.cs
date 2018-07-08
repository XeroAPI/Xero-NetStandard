using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.WebUtilities;
using Xero.Api.Infrastructure.Http;
using Xero.Api.Infrastructure.Interfaces;

namespace Xero.Api.Infrastructure.OAuth
{
    public class OAuthTokens
    {
        public string RequestTokenEndpoint => "oauth/RequestToken";
        public string AccessTokenEndpoint => "oauth/AccessToken";
        public string AuthoriseEndpoint => "oauth/Authorize";

        private static HttpClient _httpClient;

        public OAuthTokens(string baseUri)
        {

            if (_httpClient == null)
            {
                _httpClient = new HttpClient
                {
                    BaseAddress = new Uri(baseUri)
                };
            }
        }

        public Task<IToken> GetRequestTokenAsync(IConsumer consumer, string header)
        {
            return GetTokenAsync(new Token { ConsumerKey = consumer.ConsumerKey, ConsumerSecret = consumer.ConsumerSecret }, RequestTokenEndpoint, header);
        }

        public Task<IToken> GetAccessTokenAsync(IToken token, string header)
        {
            return GetTokenAsync(token, AccessTokenEndpoint, header);
        }

        public Task<IToken> RenewAccessTokenAsync(IToken token, string header)
        {
            return GetTokenAsync(token, AccessTokenEndpoint, header);
        }

        public async Task<IToken> GetTokenAsync(IToken consumer, string endpoint, string header)
        {
            var request = new HttpRequestMessage(HttpMethod.Post, endpoint);

            request.Headers.UserAgent.Add(new ProductInfoHeaderValue(new ProductHeaderValue(Uri.EscapeDataString("Xero-NetStandard - " + consumer.ConsumerKey))));

            request.Headers.Add("Authorization", header);

            var response = await _httpClient.SendAsync(request).ConfigureAwait(false);
            var body = await response.Content.ReadAsStringAsync().ConfigureAwait(false);


            if (response.StatusCode != HttpStatusCode.OK)
            {
                if (body.Contains("oauth_problem"))
                {
                    throw new OAuthException(body);
                }

                throw new UnexpectedOauthResponseException(response.StatusCode, body);
            }

            var qs = QueryHelpers.ParseQuery(body);
            qs.TryGetValue("oauth_expires_in", out var expires);
            qs.TryGetValue("oauth_session_handle", out var session);
            qs.TryGetValue("oauth_token", out var tokenKey);
            qs.TryGetValue("oauth_token_secret", out var tokenSecret);
            qs.TryGetValue("xero_org_muid", out var organisationId);
            qs.TryGetValue("oauth_authorization_expires_in", out var authExpiresIn);


            var token = new Token(consumer.ConsumerKey, consumer.ConsumerSecret)
            {
                TokenKey = tokenKey,
                TokenSecret = tokenSecret,
                OrganisationId = organisationId
            };

            if (!string.IsNullOrWhiteSpace(expires))
            {
                token.ExpiresAt = DateTime.UtcNow.AddSeconds(int.Parse(expires));
            }

            if (!string.IsNullOrWhiteSpace(session))
            {
                token.Session = session;
                token.SessionExpiresAt = DateTime.UtcNow.AddSeconds(int.Parse(authExpiresIn));
            }

            return token;
        }
    }
}
