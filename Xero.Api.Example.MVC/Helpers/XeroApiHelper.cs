using System;
using Microsoft.Extensions.Configuration;
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
        private static IMvcAuthenticator Authenticator;

        static XeroApiHelper()
        {
            var config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

            var apiSettings = config.GetSection("XeroApi");

            //Are you using a partner app?
            var isPartnerApp = bool.Parse(apiSettings["IsPartnerApp"]);
           
            // Set up some token stores to hold request and access tokens
            var accessTokenStore = new MemoryTokenStore();
            var requestTokenStore = new MemoryTokenStore();

            // Set the application settings with an authenticator relevant to your app type 
            if (isPartnerApp)
            {
                Authenticator = new PartnerMvcAuthenticator(requestTokenStore, accessTokenStore);
            }
            else
            {
                Authenticator = new PublicMvcAuthenticator(requestTokenStore, accessTokenStore);
            }
        }

        public static ApiUser User()
        {
            return new ApiUser { Identifier = Environment.MachineName };
        }

        public static IMvcAuthenticator MvcAuthenticator()
        {
            return Authenticator;
        }

        public static IMvcAuthenticator MvcAuthenticator(XeroApiSettings applicationSettings)
        {
            
            // Set up some token stores to hold request and access tokens
            var accessTokenStore = new MemoryTokenStore();
            var requestTokenStore = new MemoryTokenStore();

            // Set the application settings with an authenticator relevant to your app type 
            if (applicationSettings.IsPartnerApp)
            {
                Authenticator = new PartnerMvcAuthenticator(requestTokenStore, accessTokenStore);
            }
            else
            {
                Authenticator = new PublicMvcAuthenticator(requestTokenStore, accessTokenStore);
            }
            return Authenticator;
        }

        public static IXeroCoreApi CoreApi()
        {
            return new XeroCoreApi(Authenticator as IAuthenticator, User());
        }

        public static IXeroCoreApi CoreApi(XeroApiSettings applicationSettings)
        {
            return new XeroCoreApi(Authenticator as IAuthenticator,applicationSettings, User());
        }
    }
}
