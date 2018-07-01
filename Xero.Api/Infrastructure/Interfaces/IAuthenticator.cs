using System.Net.Http;
using System.Threading.Tasks;

namespace Xero.Api.Infrastructure.Interfaces
{
    public interface IAuthenticator
    {
        Task AuthenticateAsync(HttpRequestMessage request, IConsumer consumer, IUser user);
    }
}
