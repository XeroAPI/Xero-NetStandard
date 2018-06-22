using System.Threading.Tasks;

namespace Xero.Api.Infrastructure.Interfaces
{
    public interface ITokenStoreAsync
    {
        Task<IToken> FindAsync(string user);
        Task AddAsync(IToken token);
        Task DeleteAsync(IToken token);
    }
}