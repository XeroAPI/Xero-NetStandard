using System.Threading.Tasks;
using Xero.Api.Infrastructure.Interfaces;

namespace Xero.Api.Example.MVC.Authenticators
{
    public interface IMvcAuthenticator
    {
        Task<string> GetRequestTokenAuthorizeUrlAsync(string userId);
        Task<IToken> RetrieveAndStoreAccessTokenAsync(string userId, string tokenKey, string verifier);
    }
}