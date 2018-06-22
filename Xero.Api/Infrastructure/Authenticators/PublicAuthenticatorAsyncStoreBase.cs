﻿using System;
using System.Threading.Tasks;
using Xero.Api.Infrastructure.Interfaces;
using Xero.Api.Infrastructure.OAuth.Signing;

namespace Xero.Api.Infrastructure.Authenticators
{
    public abstract class PublicAuthenticatorAsyncStoreBase : TokenStoreAsyncAuthenticatorBase
    {
        protected PublicAuthenticatorAsyncStoreBase(ITokenStoreAsync store, IXeroApiSettings applicationSettings) 
            : base(store, applicationSettings)
        {
        }

        protected override string CreateSignature(IToken token, string verb, Uri uri, string verifier, bool renewToken = false, string callback = null)
        {
            return new HmacSha1Signer().CreateSignature(token, uri, verb, verifier, callback);
        }

        protected override async Task<IToken> RenewTokenAsync(IToken sessionToken, IConsumer consumer)
        {
            return await GetTokenAsync(consumer).ConfigureAwait(false);
        }
    }
}