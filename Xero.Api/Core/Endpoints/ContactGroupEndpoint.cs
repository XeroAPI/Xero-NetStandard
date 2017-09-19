using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
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
        IContactCollection this[Guid guid] { get; }
        ContactGroup Add(ContactGroup contactGroup);
    }

    public class ContactGroupsEndpoint : XeroUpdateEndpoint<ContactGroupsEndpoint,ContactGroup,ContactGroupsRequest,ContactGroupsResponse>,
        IContactGroupsEndpoint
    {

        public ContactGroupsEndpoint(XeroHttpClient client) : base(client,"/api.xro/2.0/ContactGroups")
        {
            
        }

        public IContactCollection this[Guid guid]
        {
            get
            {
                var endpoint = string.Format("/api.xro/2.0/ContactGroups/{0}",guid);

                var group = HandleResponse(Client
                    .Get(endpoint,null))
                    .ContactGroups.SingleOrDefault();

                var collection = new ContactCollection(Client, group);

                return collection;
            }
        }

        public ContactGroup Add(ContactGroup contactGroup)
        {
            var endpoint = string.Format("/api.xro/2.0/ContactGroups");

            var groups = HandleResponse(Client
                .Put(endpoint, new List<ContactGroup> { contactGroup }))
                .ContactGroups;

            return groups.FirstOrDefault();
        }
        
        private ContactGroupsResponse HandleResponse(HttpResponseMessage response)
        {
            if (response.StatusCode == HttpStatusCode.OK)
            {
                var body = response.Content.ReadAsStringAsync().Result;

                var result = Client.JsonMapper.From<ContactGroupsResponse>(body);
                return result;
            }

            Client.HandleErrors(response);

            return null;
        }
    }

    public interface IContactCollection :
        IXeroUpdateEndpoint<ContactGroupsEndpoint, ContactGroup, ContactGroupsRequest, ContactGroupsResponse>
    {
        void Clear();
        void Add(Contact contact);
        void AddRange(List<Contact> contacts);
        void Remove(Guid guid);
    }

    public class ContactCollection  : XeroUpdateEndpoint<ContactGroupsEndpoint, ContactGroup, ContactGroupsRequest, ContactGroupsResponse>, IContactCollection
    {
        private readonly ContactGroup _group;
        private readonly XeroHttpClient _client;


        public ContactCollection(XeroHttpClient client, ContactGroup group)
            : base(client, "/api.xro/2.0/ContactGroups")
        {
            _group = group;
            _client = client;
        }

        public void Clear()
        {
            var endpoint = string.Format("/api.xro/2.0/ContactGroups/{0}/Contacts", _group.Id);

            var groups = HandleResponse(Client
                .Delete(endpoint));
        }

        public void Add(Contact contact)
        {
            var contactList = new List<Contact>();

            contactList.Add(contact);
            
            AssignContacts(_group, contactList);

        }

        public void AddRange(List<Contact> contacts)
        {
            AssignContacts(_group,contacts);
        }

        public void Remove(Guid guid)
        {
            UnAssignContact(_group, guid);
        }

        private void UnAssignContact(ContactGroup contactGroup, Guid contactId)
        {
            var endpoint = string.Format("/api.xro/2.0/ContactGroups/{0}/Contacts/{1}", contactGroup.Id, contactId);

            var groups = HandleResponse(Client
                .Delete(endpoint));

        }

        private void AssignContacts(ContactGroup contactGroup, List<Contact> contacts)
        {
            var endpoint = string.Format("/api.xro/2.0/ContactGroups/{0}/Contacts", contactGroup.Id);

            var groups = HandleResponse(_client
                .Put(endpoint, contacts))
                .ContactGroups;
        }

        private ContactGroupsResponse HandleResponse(HttpResponseMessage response)
        {
            var body = response.Content.ReadAsStringAsync().Result;

            if (response.StatusCode == HttpStatusCode.OK)
            {
                var result = Client.JsonMapper.From<ContactGroupsResponse>(body);
                return result;
            }

            Client.HandleErrors(response);

            return null;
        }
    }
}
