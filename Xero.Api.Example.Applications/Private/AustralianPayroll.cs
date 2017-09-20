using Xero.Api.Infrastructure.Interfaces;
using Xero.Api.Infrastructure.RateLimiter;

namespace Xero.Api.Example.Applications.Private
{
    public class AustralianPayroll : Payroll.AustralianPayroll
    {
        private static readonly ApplicationSettings ApplicationSettings = new ApplicationSettings();

        public AustralianPayroll(bool includeRateLimiter = false) :
            this(new PrivateAuthenticator(ApplicationSettings.SigningCertificatePath, ApplicationSettings.SigningCertificatePassword), includeRateLimiter)
        {
        }

        public AustralianPayroll(IAuthenticator authenticator, bool includeRateLimiter = false)
            : base(authenticator, rateLimiter: includeRateLimiter ? new RateLimiter() : null)
        {
        }
    }
}