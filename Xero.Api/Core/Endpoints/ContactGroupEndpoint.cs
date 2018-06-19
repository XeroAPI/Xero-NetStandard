using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xero.Api.Core.Endpoints.Base;
using Xero.Api.Core.Model;
using Xero.Api.Core.Request;
using Xero.Api.Core.Response;
using Xero.Api.Infrastructure.Http;

namespace Xero.Api.Core.Endpoints
{
    public interface IContactGroupsEndpoint :
        IXeroUpdateEndpoint<ContactGroupsEndpoint, ContactGroup, ContactGroupsRequest, ContactGroupsResponse>
    {
        Task AddContactAsync(ContactGroup contactGroup, Contact contact);
        Task AddContactsAsync(ContactGroup contactGroup, List<Contact> contacts);
        Task RemoveContactAsync(ContactGroup contactGroup, Contact contact);
        Task ClearContactsAsync(ContactGroup contactGroup);
    }

    public class ContactGroupsEndpoint : XeroUpdateEndpoint<ContactGroupsEndpoint,ContactGroup,ContactGroupsRequest,ContactGroupsResponse>,
        IContactGroupsEndpoint
    {

        public ContactGroupsEndpoint(XeroHttpClient client) : base(client,"/api.xro/2.0/ContactGroups")
        {}

        public async Task ClearContactsAsync(ContactGroup contactGroup)
        {
            var endpoint = string.Format("/api.xro/2.0/ContactGroups/{0}/Contacts", contactGroup.Id);

            var response = await Client.DeleteAsync(endpoint).ConfigureAwait(false);

            await HandleResponseAsync(response).ConfigureAwait(false);
        }

        public async Task AddContactAsync(ContactGroup contactGroup, Contact contact)
        {
            await AddContactsAsync(contactGroup, new List<Contact>{contact}).ConfigureAwait(false);
        }

        public async Task AddContactsAsync(ContactGroup contactGroup, List<Contact> contacts)
        {
            var endpoint = string.Format("/api.xro/2.0/ContactGroups/{0}/Contacts", contactGroup.Id);

            var response = await Client.PutAsync(endpoint, contacts).ConfigureAwait(false);

            await HandleResponseAsync(response).ConfigureAwait(false);
        }

        public async Task RemoveContactAsync(ContactGroup contactGroup, Contact contact)
        {
            var endpoint = string.Format("/api.xro/2.0/ContactGroups/{0}/Contacts/{1}", contactGroup.Id, contact.Id);

            var response = await Client.DeleteAsync(endpoint).ConfigureAwait(false);

            await HandleResponseAsync(response).ConfigureAwait(false);
        }

        private async Task<ContactGroupsResponse> HandleResponseAsync(HttpResponseMessage response)
        {
            var body = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                var result = Client.JsonMapper.From<ContactGroupsResponse>(body);
                return result;
            }

            await Client.HandleErrorsAsync(response).ConfigureAwait(false);

            return null;
        }

    }
}
