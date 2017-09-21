using System;
using System.Net.Http;

namespace Xero.Api.Infrastructure.Interfaces
{
    public interface IAuthenticator
    {
        void Authenticate(HttpRequestMessage request, IConsumer consumer, IUser user);
    }
}
