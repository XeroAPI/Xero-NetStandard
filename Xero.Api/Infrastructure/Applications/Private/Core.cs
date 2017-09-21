using Xero.Api.Core;
using Xero.Api.Infrastructure.Authenticators;
using Xero.Api.Infrastructure.Interfaces;

namespace Xero.Api.Infrastructure.Applications.Private
{
    public class Core : XeroCoreApi
    {
        private static readonly ApplicationSettings ApplicationSettings = new ApplicationSettings();

        public Core(bool includeRateLimiter = false) :
            this(new PrivateAuthenticator(ApplicationSettings.SigningCertificatePath, ApplicationSettings.SigningCertificatePassword), includeRateLimiter)
        {
        }

        public Core(IAuthenticator authenticator, bool includeRateLimiter = false)
            : base(authenticator, rateLimiter: includeRateLimiter ? new RateLimiter.RateLimiter() : null)
        {
        }
    }
}
