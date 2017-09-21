using System;
using Xero.Api.Example.Creation.Helpers;
using Xero.Api.Infrastructure.Authenticators;
using Xero.Api.Infrastructure.Interfaces;

namespace Xero.Api.Example.Creation.Authenticators
{
    public class PartnerAuthenticator : PartnerAuthenticatorBase
    {
        public PartnerAuthenticator(ITokenStore store) 
            : base(store)
        {
        }

        protected override string AuthorizeUser(IToken token, string scope = null, bool redirectOnError = false)
        {
            var authorizeUrl = GetAuthorizeUrl(token, scope, redirectOnError);

            ProcessHelper.OpenBrowser(authorizeUrl);

            Console.WriteLine("Enter the PIN given on the web page");

            return Console.ReadLine();
        }
    }
}
