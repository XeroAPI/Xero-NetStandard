using System;

namespace Xero.NetStandard.OAuth2.Client
{
    public class RateLimitException : Exception
    {
        public int RetryAfter { get; }
        public string LimitType { get; }
        public string Site { get; }

        public RateLimitException(int retryAfter, string limitType, string site)
            : base($"Xero API {limitType} rate limit error calling {site} (retry in {retryAfter} seconds)")
        {
            RetryAfter = retryAfter;
            LimitType = limitType;
            Site = site;
        }
    }
}