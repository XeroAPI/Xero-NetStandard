using Xero.Api.Common;
using Xero.Api.Core.Endpoints.Base;
using Xero.Api.Core.Model;
using Xero.Api.Core.Request;
using Xero.Api.Core.Response;
using Xero.Api.Infrastructure.Http;

namespace Xero.Api.Core.Endpoints
{
    public interface ICreditNotesEndpoint :
        IXeroUpdateEndpoint<CreditNotesEndpoint, CreditNote, CreditNotesRequest, CreditNotesResponse>, IPageableEndpoint<ICreditNotesEndpoint>
    {
        
    }

    public class CreditNotesEndpoint
        : FourDecimalPlacesEndpoint<CreditNotesEndpoint, CreditNote, CreditNotesRequest, CreditNotesResponse>, ICreditNotesEndpoint
    {
        public CreditNotesEndpoint(XeroHttpClient client) :
            base(client, "/api.xro/2.0/CreditNotes")
        {
            AddParameter("page", 1, false);
        }

        public ICreditNotesEndpoint Page(int page)
        {
            return AddParameter("page", page);
        }

        public override void ClearQueryString()
        {
            base.ClearQueryString();
            AddParameter("page", 1, false);
        }
    }
}