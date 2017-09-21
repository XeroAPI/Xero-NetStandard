using System;
using Xero.Api.Example.Creation.Authenticators;
using Xero.Api.Example.Creation.TokenStores;
using Xero.Api.Infrastructure.OAuth;

namespace Xero.Api.Example.Creation
{
    class Program
    {
        static void Main(string[] args)
        {
            var tokenStore = new MemoryTokenStore();
            var user = new ApiUser { Identifier = Environment.MachineName };

            var authenticator = new PublicAuthenticator(tokenStore);

            var api = new Infrastructure.Applications.Public.Core(authenticator, user)
            {
                UserAgent = "Xero Api - Creating example"
            };

            var creator = new Creator.Creator();
            new ApiDataCreation(api).Create(10, 10,
                creator.People(5),
                creator.Addresses(5),
                creator.Descriptions(5));
        }
    }
}
