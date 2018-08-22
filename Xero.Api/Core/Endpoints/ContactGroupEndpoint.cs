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
        private readonly string _endpointBase;

        public ContactGroupsEndpoint(XeroHttpClient client)
            : this(client, "/api.xro/2.0")
        { }

        public ContactGroupsEndpoint(XeroHttpClient client, string endpointBase) 
            : base(client,$"{endpointBase}/ContactGroups")
        {
            _endpointBase = endpointBase;
        }

        public async Task ClearContactsAsync(ContactGroup contactGroup)
        {
            var endpoint = $"{_endpointBase}/ContactGroups/{contactGroup.Id}/Contacts";

            var response = await Client.DeleteAsync(endpoint).ConfigureAwait(false);

            await HandleResponseAsync(response).ConfigureAwait(false);
        }

        public Task AddContactAsync(ContactGroup contactGroup, Contact contact)
        {
            return AddContactsAsync(contactGroup, new List<Contact> { contact });
        }

        public async Task AddContactsAsync(ContactGroup contactGroup, List<Contact> contacts)
        {
            var endpoint = $"{_endpointBase}/ContactGroups/{contactGroup.Id}/Contacts";

            var response = await Client.PutAsync(endpoint, contacts).ConfigureAwait(false);

            await HandleResponseAsync(response).ConfigureAwait(false);
        }

        public async Task RemoveContactAsync(ContactGroup contactGroup, Contact contact)
        {
            var endpoint = $"{_endpointBase}/ContactGroups/{contactGroup.Id}/Contacts/{contact.Id}";

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
