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
            var api = PrivateApp();

            new Lister(api).List();
        }

        private static IXeroCoreApi PrivateApp()
        {
            return new Infrastructure.Applications.Private.Core
            {
                UserAgent = "Xero Api - Listing example"
            };
        }

        private static IXeroCoreApi PublicApp()
        {
            var tokenStore = new MemoryTokenStore();
            var user = new ApiUser { Identifier = Environment.MachineName };

            var publicAuth = new PublicAuthenticator(tokenStore);

            return new Infrastructure.Applications.Public.Core(publicAuth, user)
            {
                UserAgent = "Xero Api - Listing example"
            };
        }

        private IXeroCoreApi PartnerApp()
        {
            var tokenStore = new MemoryTokenStore();
            var user = new ApiUser { Identifier = Environment.MachineName };
            var partnerAuth = new PartnerAuthenticator(tokenStore);

            return new Infrastructure.Applications.Partner.Core(partnerAuth, user)
            {
                UserAgent = "Xero Api - Listing example"
            };
        }
    }
}
