using System;
using System.Net.Http;
using System.Threading.Tasks;
using Xero.Api.Infrastructure.Interfaces;
using Xero.Api.Infrastructure.OAuth;

namespace Xero.Api.Infrastructure.Authenticators
{
    public abstract class AuthenticatorBase : IAuthenticator
    {
        protected readonly IXeroApiSettings ApplicationSettings;

        protected string BaseUri => ApplicationSettings.BaseUrl;
        protected string CallBackUri => ApplicationSettings.CallbackUrl;

        private OAuthTokens _tokens;

        protected OAuthTokens Tokens => _tokens ?? (_tokens = new OAuthTokens(BaseUri));

        protected AuthenticatorBase(IXeroApiSettings applicationSettings)
        {
            ApplicationSettings = applicationSettings;
        }

        protected abstract string AuthorizeUser(IToken oauthToken, string scope = null, bool redirectOnError = false);

        protected abstract string CreateSignature(IToken token, string verb, Uri uri, string verifier, bool renewToken = false, string callback = null);

        protected abstract Task<IToken> RenewTokenAsync(IToken sessionToken, IConsumer consumer);

        public async Task AuthenticateAsync(HttpRequestMessage request, IConsumer consumer, IUser user)
        {
            var token = await GetTokenAsync(consumer, user).ConfigureAwait(false);

            var authString = GetAuthorization(token, request.Method.Method, request.RequestUri.AbsolutePath, request.RequestUri.Query);

            request.Headers.Add("Authorization", authString);
        }

        protected abstract Task<IToken> GetTokenAsync(IConsumer consumer, IUser user);

        protected virtual async Task<IToken> GetTokenAsync(IConsumer consumer)
        {
            var requestToken = await GetRequestTokenAsync(consumer).ConfigureAwait(false);
   
            var verifier = AuthorizeUser(requestToken);

            return await Tokens.GetAccessTokenAsync(requestToken, GetAuthorization(requestToken, "POST", Tokens.AccessTokenEndpoint, null, verifier)).ConfigureAwait(false);
        }

        protected async Task<IToken> GetRequestTokenAsync(IConsumer consumer)
        {
            var token = new Token
            {
                ConsumerKey = consumer.ConsumerKey,
                ConsumerSecret = consumer.ConsumerSecret
            };
            
            var requestTokenOAuthHeader = GetAuthorization(token, "POST", Tokens.RequestTokenEndpoint, callback: CallBackUri);

            return await Tokens.GetRequestTokenAsync(consumer, requestTokenOAuthHeader).ConfigureAwait(false);
        }

        protected string GetAuthorization(IToken token, string verb, string endpoint, string query = null,
            string verifier = null, bool renewToken = false, string callback = null)
        {
            var uri = new UriBuilder(BaseUri)
            {
                Path = endpoint
            };

            if (!string.IsNullOrWhiteSpace(query))
            {
                uri.Query = query.TrimStart('?');
            }

            return CreateSignature(token, verb, uri.Uri, verifier, renewToken, callback);
        }

        protected string GetAuthorizeUrl(IToken token, string scope = null, bool redirectOnError = false)
        {
            return new UriBuilder(BaseUri)
            {
                Path = Tokens.AuthoriseEndpoint,
                Query = $"oauth_token={token.TokenKey}&scope={scope}&redirectOnError={redirectOnError}"
            }.Uri.ToString();
        }
    }
}
