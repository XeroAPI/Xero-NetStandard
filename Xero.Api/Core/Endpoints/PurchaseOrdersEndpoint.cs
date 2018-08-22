using System;
using Xero.Api.Common;
using Xero.Api.Core.Endpoints.Base;
using Xero.Api.Core.Model;
using Xero.Api.Core.Model.Status;
using Xero.Api.Core.Request;
using Xero.Api.Core.Response;
using Xero.Api.Infrastructure.Http;

namespace Xero.Api.Core.Endpoints
{
    public interface IPurchaseOrdersEndpoint :
        IXeroUpdateEndpoint<PurchaseOrdersEndpoint, PurchaseOrder, PurchaseOrdersRequest, PurchaseOrdersResponse>, IPageableEndpoint<IPurchaseOrdersEndpoint>
    {
        PurchaseOrdersEndpoint Status(PurchaseOrderStatus status);
        PurchaseOrdersEndpoint DateFrom(DateTime dateFrom);
        PurchaseOrdersEndpoint DateTo(DateTime dateTo);
    }

    public class PurchaseOrdersEndpoint : XeroUpdateEndpoint<PurchaseOrdersEndpoint, PurchaseOrder, PurchaseOrdersRequest, PurchaseOrdersResponse>, IPurchaseOrdersEndpoint
    {
        public PurchaseOrdersEndpoint(XeroHttpClient client) :
            this(client, "/api.xro/2.0")
        {
        }

        public PurchaseOrdersEndpoint(XeroHttpClient client, string endpointBase) :
            base(client, $"{endpointBase}/PurchaseOrders")
        {
            AddParameter("page", 1, false);
        }

        public IPurchaseOrdersEndpoint Page(int page)
        {
            return AddParameter("page", page);
        }

        public PurchaseOrdersEndpoint Status(PurchaseOrderStatus status)
        {
            return AddParameter("status", status.ToString().ToUpper());
        }

        public PurchaseOrdersEndpoint DateFrom(DateTime dateFrom)
        {
            return AddParameter("dateFrom", dateFrom.ToString("yyyy-MM-dd"));
        }

        public PurchaseOrdersEndpoint DateTo(DateTime dateTo)
        {
            return AddParameter("dateTo", dateTo.ToString("yyyy-MM-dd"));
        }

        public override void ClearQueryString()
        {
            base.ClearQueryString();
            AddParameter("page", 1, false);
        }
    }
}
