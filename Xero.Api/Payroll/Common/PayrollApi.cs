using Xero.Api.Common;
using Xero.Api.Infrastructure.Interfaces;
using Xero.Api.Infrastructure.OAuth;
using Xero.Api.Infrastructure.RateLimiter;

namespace Xero.Api.Payroll.Common
{
    public abstract class PayrollApi : XeroApi
    {
        private static readonly XeroApiSettings ApplicationSettings = new XeroApiSettings();

        protected PayrollApi(IAuthenticator auth, IUser user = null, IRateLimiter rateLimiter = null)
            : base(ApplicationSettings.BaseUrl, auth, new Consumer(ApplicationSettings.ConsumerKey, ApplicationSettings.ConsumerSecret), user, rateLimiter)
        {
        }

        protected PayrollApi(string baseUrl, IAuthenticator auth, IUser user = null, IConsumer consumer = null, IRateLimiter rateLimiter = null)
            : base(baseUrl, auth, consumer, user, rateLimiter)
        {
        }
    }
}