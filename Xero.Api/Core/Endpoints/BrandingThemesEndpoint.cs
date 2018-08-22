using Xero.Api.Common;
using Xero.Api.Core.Model;
using Xero.Api.Core.Response;
using Xero.Api.Infrastructure.Http;

namespace Xero.Api.Core.Endpoints
{
    public interface IBrandingThemesEndpoint :
        IXeroReadEndpoint<BrandingThemesEndpoint, BrandingTheme, BrandingThemesResponse>
    {
        
    }

    public class BrandingThemesEndpoint : XeroReadEndpoint<BrandingThemesEndpoint, BrandingTheme, BrandingThemesResponse>, IBrandingThemesEndpoint
    {
        public BrandingThemesEndpoint(XeroHttpClient client)
            : this(client, "/api.xro/2.0")
        {
        }

        public BrandingThemesEndpoint(XeroHttpClient client, string endpointBase)
            : base(client, $"{endpointBase}/BrandingThemes")
        {
        }
    }
}