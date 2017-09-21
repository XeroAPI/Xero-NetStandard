using System;
using Xero.Api.Example.Console.Authenticators;
using Xero.Api.Infrastructure.OAuth;
using MemoryTokenStore = Xero.Api.Example.Console.TokenStores.MemoryTokenStore;

namespace Xero.Api.Example.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var tokenStore = new MemoryTokenStore();
            var user = new ApiUser { Identifier = Environment.MachineName };

            //////// Private
            var privateApi = new Infrastructure.Applications.Private.Core
            {
                UserAgent = "Xero Api - Listing example"
            };

            new Lister(privateApi).List();

            //////// Public

            var publicAuth = new PublicAuthenticator(tokenStore);

            var publicApi = new Infrastructure.Applications.Public.Core(publicAuth, user)
            {
                UserAgent = "Xero Api - Listing example"
            };

            new Lister(publicApi).List();

            ////////// Partner

            var partnerAuth = new PartnerAuthenticator(tokenStore);

            var partnerApi = new Infrastructure.Applications.Partner.Core(partnerAuth, user)
            {
                UserAgent = "Xero Api - Listing example"
            };

            new Lister(partnerApi).List();
        }
    }
}
