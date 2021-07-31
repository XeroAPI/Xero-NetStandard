namespace Xero.NetStandard.OAuth2.Client
{
    /// <summary>
    /// An API Exception caused by hitting the call rate limit
    /// </summary>
    public class RateLimitException : ApiException
    {
        /// <summary>
        /// Gets the retry after value
        /// </summary>
        /// <value>
        /// The number of seconds the client should wait before retrying the request.
        /// Set from the value of the Retry-After header returned by the server.
        /// </value>
        public int RetryAfter { get; }

        /// <summary>
        /// Gets the limit type
        /// </summary>
        /// <value>The type of the rate limit hit, such as minute or daily</value>
        public string LimitType { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="RateLimitException" /> class
        /// </summary>
        /// <param name="retryAfter">Number of seconds to wait before retrying</param>
        /// <param name="limitType">The type of limit hit</param>
        /// <param name="methodName">The method that was called</param>
        /// <param name="content">Error content</param>
        public RateLimitException(int retryAfter, string limitType, string methodName, object content)
            : base(429, $"Xero API {limitType} rate limit error calling {methodName}", content)
        {
            this.RetryAfter = retryAfter;
            this.LimitType = limitType;
        }
    }
}
