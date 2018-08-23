using System;
using Xero.Api.Core;
using Xero.Api.Example.Console.Authenticators;
using Xero.Api.Infrastructure.OAuth;
using MemoryTokenStore = Xero.Api.Example.Console.TokenStores.MemoryTokenStore;

namespace Xero.Api.Example.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var api = Initialise();
            
            new Lister(api).List();
        }

        private static IXeroCoreApi Initialise()
        {
            var settings = new XeroApiSettings();

            switch (settings.AppType)
            {
                case XeroApiAppType.Private:
                    return PrivateApp();
                case XeroApiAppType.Public:
                    return PublicApp();
                case XeroApiAppType.Partner:
                    return PartnerApp();
                default: throw new ApplicationException("AppType did not match one of: private, public, partner");
            }
        }

        private static IXeroCoreApi PrivateApp()
        {
            return new Infrastructure.Applications.Private.Core
            {
                UserAgent = "Xero API - Listing example"
            };
        }

        private static IXeroCoreApi PublicApp()
        {
            var tokenStore = new MemoryTokenStore();
            var user = new ApiUser { Identifier = Environment.MachineName };

            var publicAuth = new PublicAuthenticator(tokenStore);
            
            return new Infrastructure.Applications.Public.Core(publicAuth, user)
            {
                UserAgent = "Xero API - Listing example"
            };
        }

        private static IXeroCoreApi PartnerApp()
        {
            var tokenStore = new MemoryTokenStore();
            var user = new ApiUser { Identifier = Environment.MachineName };
            var partnerAuth = new PartnerAuthenticator(tokenStore);

            return new Infrastructure.Applications.Partner.Core(partnerAuth, user)
            {
                UserAgent = "Xero API - Listing example"
            };
        }
    }
}
