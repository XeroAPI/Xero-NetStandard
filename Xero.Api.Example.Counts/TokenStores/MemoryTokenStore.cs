using System.Collections.Concurrent;
using System.Collections.Generic;
using Xero.Api.Infrastructure.Interfaces;

namespace Xero.Api.Example.Counts.TokenStores
{
    public class MemoryTokenStore : ITokenStore
    {
        private readonly IDictionary<string, IToken> _tokens = new ConcurrentDictionary<string, IToken>();

        public IToken Find(string userId)
        {
            if (string.IsNullOrWhiteSpace(userId))
                return null;

            _tokens.TryGetValue(userId, out var token);
            return token;
        }

        public void Add(IToken token)
        {
            _tokens[token.UserId] = token;
        }

        public void Delete(IToken token)
        {
            if (_tokens.ContainsKey(token.UserId))
            {
                _tokens.Remove(token.UserId);
            }
        }
    }
}
