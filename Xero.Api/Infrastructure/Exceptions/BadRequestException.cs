using System;
using System.Net;

namespace Xero.Api.Infrastructure.Exceptions
{
    [Serializable]
    public class BadRequestException
        : XeroApiException
    {
        public BadRequestException() { }

        public BadRequestException(ApiException apiException)
            : base(HttpStatusCode.BadRequest, apiException.Message)
        {
            ErrorNumber = apiException.ErrorNumber;
            Type = apiException.Type;            
        }

        public int ErrorNumber { get; private set; }
        public string Type { get; private set; }        
    }
}
