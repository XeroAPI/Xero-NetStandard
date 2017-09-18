using System;
using System.Collections.Generic;
using System.Threading;

namespace Xero.Api.Infrastructure.RateLimiter
{
    public class RateLimiter : IRateLimiter
    {
        private readonly TimeSpan _duration;
        private readonly int _qty;
        private readonly Queue<DateTime> rateLimiter;

        /// <summary>
        /// Create an instance of this class that allows x requests over y seconds
        /// </summary>
        /// <param name="duration"></param>
        /// <param name="qty"></param>
        public RateLimiter(TimeSpan duration, int qty)
        {
            this._duration = duration;
            this._qty = qty;
            this.rateLimiter = new Queue<DateTime>(qty);
        }

        public RateLimiter() : this(TimeSpan.FromMinutes(1), 60) { }

        /// <summary>
        /// Don't return from this method until we're back under the limit
        /// </summary>
        public void WaitUntilLimit()
        {
            while (rateLimiter.Count >= _qty)
            {
                var diff = rateLimiter.Peek().Add(_duration) - DateTime.UtcNow;
                if (diff.TotalMilliseconds > 0)
                    Thread.Sleep((int)diff.TotalMilliseconds + 1000);
                rateLimiter.Dequeue();
            }
            rateLimiter.Enqueue(DateTime.UtcNow);
        }

        /// <summary>
        /// Check whether we've used up all of the allocation
        /// </summary>
        /// <returns>True if we're over the limit, false if we've got some allocation left</returns>
        public bool CheckLimit()
        {
            return (rateLimiter.Count >= _qty && rateLimiter.Peek().Add(_duration) > DateTime.UtcNow);
        }
    }
}
