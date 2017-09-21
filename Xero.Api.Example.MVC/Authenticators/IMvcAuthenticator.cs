using Xero.Api.Infrastructure.Interfaces;

namespace Xero.Api.Example.MVC.Authenticators
{
    public interface IMvcAuthenticator
    {
        string GetRequestTokenAuthorizeUrl(string userId);
        IToken RetrieveAndStoreAccessToken(string userId, string tokenKey, string verfier);
    }
}