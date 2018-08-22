using Xero.Api.Core.Endpoints.Base;
using Xero.Api.Core.Model;
using Xero.Api.Core.Request;
using Xero.Api.Core.Response;
using Xero.Api.Infrastructure.Http;

namespace Xero.Api.Core.Endpoints
{
    public interface ITaxRatesEndpoint : IXeroUpdateEndpoint<TaxRatesEndpoint, TaxRate, TaxRatesRequest, TaxRatesResponse>
    {

    }

    public class TaxRatesEndpoint
        : XeroUpdateEndpoint<TaxRatesEndpoint, TaxRate, TaxRatesRequest, TaxRatesResponse>, ITaxRatesEndpoint
    {
        public TaxRatesEndpoint(XeroHttpClient client)
            : this(client, "/api.xro/2.0")
        {
        }

        public TaxRatesEndpoint(XeroHttpClient client, string endpointBase)
            : base(client, $"{endpointBase}/TaxRates")
        {
        }
    }
}