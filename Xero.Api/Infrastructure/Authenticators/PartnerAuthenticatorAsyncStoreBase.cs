﻿using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Xero.Api.Infrastructure.Interfaces;
using Xero.Api.Infrastructure.OAuth.Signing;

namespace Xero.Api.Infrastructure.Authenticators
{
    public abstract class PartnerAuthenticatorAsyncStoreBase : TokenStoreAsyncAuthenticatorBase
    {
        private readonly X509Certificate2 _signingCertificate;

        protected PartnerAuthenticatorAsyncStoreBase(ITokenStoreAsync store, IXeroApiSettings applicationSettings)
            : base(store, applicationSettings)
        {
            _signingCertificate = new X509Certificate2(ApplicationSettings.SigningCertificatePath, ApplicationSettings.SigningCertificatePassword, X509KeyStorageFlags.MachineKeySet);
        }

        protected override string CreateSignature(IToken token, string verb, Uri uri, string verifier, bool renewToken = false, string callback = null)
        {
            return new RsaSha1Signer().CreateSignature(_signingCertificate, token, uri, verb, verifier, renewToken, callback);
        }

        protected override async Task<IToken> RenewTokenAsync(IToken sessionToken, IConsumer consumer)
        {
            var authHeader = GetAuthorization(sessionToken, "POST", Tokens.AccessTokenEndpoint, null, null, true);

            return await Tokens.GetAccessTokenAsync(sessionToken, authHeader).ConfigureAwait(false);
        }
    }
}
