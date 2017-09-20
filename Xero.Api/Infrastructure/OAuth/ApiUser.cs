using Xero.Api.Infrastructure.Interfaces;

namespace Xero.Api.Infrastructure.OAuth
{
    public class ApiUser : IUser
    {
        public string Identifier { get; set; }
    }
}