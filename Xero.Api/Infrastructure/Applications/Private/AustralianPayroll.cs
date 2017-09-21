using Xero.Api.Infrastructure.Authenticators;
using Xero.Api.Infrastructure.Interfaces;

namespace Xero.Api.Infrastructure.Applications.Private
{
    public class AustralianPayroll : Payroll.AustralianPayroll
    {
        private static readonly ApplicationSettings ApplicationSettings = new ApplicationSettings();

        public AustralianPayroll(bool includeRateLimiter = false) :
            this(new PrivateAuthenticator(ApplicationSettings.SigningCertificatePath, ApplicationSettings.SigningCertificatePassword), includeRateLimiter)
        {
        }

        public AustralianPayroll(IAuthenticator authenticator, bool includeRateLimiter = false)
            : base(authenticator, rateLimiter: includeRateLimiter ? new RateLimiter.RateLimiter() : null)
        {
        }
    }
}