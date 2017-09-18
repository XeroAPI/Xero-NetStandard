using System;
using System.Net;
using Microsoft.AspNetCore.WebUtilities;
using Xero.Api.Infrastructure.Http;
using Xero.Api.Infrastructure.Interfaces;

namespace Xero.Api.Infrastructure.OAuth
{
    public class OAuthTokens
    {
        private readonly string _baseUri;
        private const string XeroRequestUri = "oauth/RequestToken";
        private const string XeroAccessTokenUri = "oauth/AccessToken";
        private const string XeroAuthorizeUri = "oauth/Authorize";

        public OAuthTokens(string baseUri)
        {
            _baseUri = baseUri;
        }

        public string AuthorizeUri
        {
            get
            {
                var uri = new UriBuilder(_baseUri)
                {
                    Path = XeroAuthorizeUri
                };

                return uri.ToString();
            }
        }

        public string RequestUri
        {
            get
            {
                return XeroRequestUri;
            }
        }

        public string AccessUri
        {
            get
            {
                return XeroAccessTokenUri;
            }
        }

        public IToken GetRequestToken(IConsumer consumer, string header)
        {
            return GetToken(_baseUri,  new Token { ConsumerKey = consumer.ConsumerKey, ConsumerSecret = consumer.ConsumerSecret }, XeroRequestUri, header);
        }

        public IToken GetAccessToken(IToken token, string header)
        {
            return GetToken(_baseUri, token, XeroAccessTokenUri, header);
        }

        public IToken RenewAccessToken(IToken token, string header)
        {
            return GetToken(_baseUri, token, XeroAccessTokenUri, header);
        }

        public IToken GetToken(string baseUri, IToken consumer, string endPoint, string header)
        {
            var req = new HttpClient(baseUri)
            {
                UserAgent = "Xero Api wrapper - " + consumer.ConsumerKey
            };
            
            req.AddHeader("Authorization", header);

            var response = req.Post(endPoint, string.Empty);

            if (response.StatusCode != HttpStatusCode.OK)
            {
                if (response.Body.Contains("oauth_problem"))
                {
                    throw new OAuthException(response.Body);
                }

                throw new UnexpectedOauthResponseException(response.StatusCode, response.Body);
            }

            var qs = QueryHelpers.ParseQuery(response.Body);

            qs.TryGetValue("oauth_expires_in", out var expires);
            qs.TryGetValue("auth_session_handle", out var session);
            qs.TryGetValue("oauth_token", out var tokenKey);
            qs.TryGetValue("oauth_token_secret", out var tokenSecret);
            qs.TryGetValue("xero_org_muid", out var organisationId);
            

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
                token.SessionExpiresAt = DateTime.UtcNow.AddSeconds(int.Parse(qs["oauth_authorization_expires_in"]));
            }

            return token;
        }
    }
}
