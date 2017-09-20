using Xero.Api.Core;
using Xero.Api.Infrastructure.Interfaces;
using Xero.Api.Infrastructure.OAuth;
using Xero.Api.Infrastructure.RateLimiter;
using Xero.Api.Serialization;

namespace Xero.Api.Example.Applications.Private
{
    public class Core : XeroCoreApi
    {
        private static ApplicationSettings _applicationSettings = new ApplicationSettings();
        private static IAuthenticator _privateAuthenticator = new PrivateAuthenticator(_applicationSettings.SigningCertificatePath, _applicationSettings.SigningCertificatePassword);

        public Core(bool includeRateLimiter = false) :
            base(_privateAuthenticator, rateLimiter: includeRateLimiter ? new RateLimiter() : null)
        {
        }
    }
}
