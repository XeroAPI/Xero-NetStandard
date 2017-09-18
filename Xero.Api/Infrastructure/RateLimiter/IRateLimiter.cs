namespace Xero.Api.Infrastructure.RateLimiter
{
    public interface IRateLimiter
    {
        void WaitUntilLimit();

        bool CheckLimit();
    }
}
