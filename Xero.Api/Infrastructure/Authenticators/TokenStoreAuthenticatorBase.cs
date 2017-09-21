using System;
using System.Net.Http;
using Xero.Api.Infrastructure.Interfaces;
using Xero.Api.Infrastructure.OAuth;

namespace Xero.Api.Infrastructure.Authenticators
{
    public abstract class TokenStoreAuthenticatorBase : IAuthenticator
    {
        protected readonly ApplicationSettings ApplicationSettings = new ApplicationSettings();

        protected string BaseUri => ApplicationSettings.BaseUrl;
        protected string CallBackUri => ApplicationSettings.CallbackUrl;
        protected ITokenStore Store { get; set; }

        private OAuthTokens _tokens;

        protected OAuthTokens Tokens => _tokens ?? (_tokens = new OAuthTokens(BaseUri));
        public bool HasStore => Store != null;


        protected TokenStoreAuthenticatorBase(ITokenStore store)
        {
            Store = store;                      
        }

        protected abstract string AuthorizeUser(IToken oauthToken, string scope = null, bool redirectOnError = false);

        protected abstract string CreateSignature(IToken token, string verb, Uri uri, string verifier, bool renewToken = false, string callback = null);

        protected abstract IToken RenewToken(IToken sessionToken, IConsumer consumer);

        public void Authenticate(HttpRequestMessage request, IConsumer consumer, IUser user)
        {
            var token = GetToken(consumer, user);

            var authString = GetAuthorization(token, request.Method.Method, request.RequestUri.AbsolutePath, request.RequestUri.Query);

            request.Headers.Add("Authorization", authString);
        }

        private IToken GetToken(IConsumer consumer, IUser user)
        {
            if (!HasStore)
                return GetToken(consumer);

            var token = Store.Find(user.Identifier);

            if (token == null)
            {
                token = GetToken(consumer);
                token.UserId = user.Identifier;

                Store.Add(token);

                return token;
            }

            if (!token.HasExpired)
                return token;
            
            var newToken = RenewToken(token, consumer);
            newToken.UserId = user.Identifier;

            Store.Delete(token);
            Store.Add(newToken);

            return newToken;
        }

        protected virtual IToken GetToken(IConsumer consumer)
        {
            var requestToken = GetRequestToken(consumer);
   
            var verifier = AuthorizeUser(requestToken);

            return Tokens.GetAccessTokenAsync(requestToken, GetAuthorization(requestToken, "POST", Tokens.AccessTokenEndpoint, null, verifier)).Result;
        }

        protected IToken GetRequestToken(IConsumer consumer)
        {
            var token = new Token
            {
                ConsumerKey = consumer.ConsumerKey,
                ConsumerSecret = consumer.ConsumerSecret
            };
            
            var requestTokenOAuthHeader = GetAuthorization(token, "POST", Tokens.RequestTokenEndpoint, callback: CallBackUri);

            return Tokens.GetRequestTokenAsync(consumer, requestTokenOAuthHeader).Result;
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
