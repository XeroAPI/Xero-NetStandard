using Xero.Api.Common;
using Xero.Api.Core.Endpoints.Base;
using Xero.Api.Core.Model;
using Xero.Api.Core.Request;
using Xero.Api.Core.Response;
using Xero.Api.Infrastructure.Http;

namespace Xero.Api.Core.Endpoints
{
    public interface IContactsEndpoint
        : IXeroUpdateEndpoint<ContactsEndpoint, Contact, ContactsRequest, ContactsResponse>,
        IPageableEndpoint<IContactsEndpoint>
    {
        IContactsEndpoint IncludeArchived(bool include);
    }

    public class ContactsEndpoint
        : XeroUpdateEndpoint<ContactsEndpoint, Contact, ContactsRequest, ContactsResponse>, IContactsEndpoint
    {
        internal ContactsEndpoint(XeroHttpClient client)
            : base(client, "/api.xro/2.0/Contacts")
        {
            AddParameter("page", 1, false);
        }

        public IContactsEndpoint Page(int page)
        {
            return AddParameter("page", page);
        }

        public IContactsEndpoint IncludeArchived(bool include)
        {
            return include ? AddParameter("includeArchived", true) : this;
        }

        public override void ClearQueryString()
        {
            base.ClearQueryString();
            AddParameter("page", 1, false);
        }
    }
}