using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xero.Api.Infrastructure.Interfaces;

namespace Xero.Api.Example.MVC.TokenStores
{
    public class MemoryTokenStore : ITokenStoreAsync
    {
        private readonly IDictionary<string, IToken> _tokens = new ConcurrentDictionary<string, IToken>();

        public Task<IToken> FindAsync(string userId)
        {
            if (string.IsNullOrWhiteSpace(userId))
                return null;

            _tokens.TryGetValue(userId, out var token);

            return Task.FromResult(token);
        }

        public Task AddAsync(IToken token)
        {
            _tokens[token.UserId] = token;

            return Task.CompletedTask;
        }

        public Task DeleteAsync(IToken token)
        {
            if (_tokens.ContainsKey(token.UserId))
            {
                _tokens.Remove(token.UserId);
            }

            return Task.CompletedTask;
        }
    }
}
