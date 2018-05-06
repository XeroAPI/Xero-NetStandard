using System;
using Xero.Api.Core;
using Xero.Api.Example.MVC.TokenStores;
using Xero.Api.Infrastructure.Interfaces;
using Xero.Api.Infrastructure.OAuth;
using IMvcAuthenticator = Xero.Api.Example.MVC.Authenticators.IMvcAuthenticator;
using PartnerMvcAuthenticator = Xero.Api.Example.MVC.Authenticators.PartnerMvcAuthenticator;
using PublicMvcAuthenticator = Xero.Api.Example.MVC.Authenticators.PublicMvcAuthenticator;

namespace Xero.Api.Example.MVC.Helpers
{
    public static class XeroApiHelper
    {
        private static IMvcAuthenticator _authenticator;

        public static ApiUser User()
        {
            return new ApiUser { Identifier = Environment.MachineName };
        }

        public static IMvcAuthenticator MvcAuthenticator()
        {
            return _authenticator;
        }

        public static IMvcAuthenticator MvcAuthenticator(XeroApiSettings applicationSettings)
        {
            // Set up some token stores to hold request and access tokens
            var accessTokenStore = new MemoryTokenStore();
            var requestTokenStore = new MemoryTokenStore();

            // Set the application settings with an authenticator relevant to your app type 
            switch (applicationSettings.AppType.ToLower())
            {
                case "public":
                    _authenticator = new PublicMvcAuthenticator(requestTokenStore, accessTokenStore);
                    break;
                case "partner":
                    _authenticator = new PartnerMvcAuthenticator(requestTokenStore, accessTokenStore);
                    break;
                case "private":
                    throw new ApplicationException("MVC cannot be used with private applications");
                case "default":
                    throw new ApplicationException("AppType did not match one of: public, partner");
            }

            return _authenticator;
        }

        public static IXeroCoreApi CoreApi()
        {
            return new XeroCoreApi(_authenticator as IAuthenticator, User());
        }
    }
}
