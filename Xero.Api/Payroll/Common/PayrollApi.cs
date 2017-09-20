using Xero.Api.Common;
using Xero.Api.Infrastructure.Interfaces;
using Xero.Api.Infrastructure.OAuth;
using Xero.Api.Infrastructure.RateLimiter;

namespace Xero.Api.Payroll.Common
{
    public abstract class PayrollApi : XeroApi
    {
        private static readonly ApplicationSettings ApplicationSettings = new ApplicationSettings();

        protected PayrollApi(IAuthenticator auth, IUser user = null, IRateLimiter rateLimiter = null)
            : base(ApplicationSettings.BaseUrl, auth, new Consumer(ApplicationSettings.Key, ApplicationSettings.Secret), user, rateLimiter)
        {
        }
    }
}