using System.Threading.Tasks;
using Xero.Api.Infrastructure.Interfaces;

namespace Xero.Api.Infrastructure.Authenticators
{
    public abstract class TokenStoreAsyncAuthenticatorBase : AuthenticatorBase
    {
        protected ITokenStoreAsync Store { get; set; }

        public bool HasStore => Store != null;

        protected TokenStoreAsyncAuthenticatorBase(ITokenStoreAsync store, IXeroApiSettings applicationSettings)
            : base(applicationSettings)
        {
            Store = store;
        }

        protected override async Task<IToken> GetTokenAsync(IConsumer consumer, IUser user)
        {
            if (!HasStore)
                return await GetTokenAsync(consumer).ConfigureAwait(false);

            var token = await Store.FindAsync(user.Identifier).ConfigureAwait(false);

            if (token == null)
            {
                token = await GetTokenAsync(consumer).ConfigureAwait(false);
                token.UserId = user.Identifier;

                await Store.AddAsync(token).ConfigureAwait(false);

                return token;
            }

            if (!token.HasExpired)
                return token;

            var newToken = await RenewTokenAsync(token, consumer).ConfigureAwait(false);
            newToken.UserId = user.Identifier;

            await Store.DeleteAsync(token).ConfigureAwait(false);
            await Store.AddAsync(newToken).ConfigureAwait(false);

            return newToken;
        }
    }
}
