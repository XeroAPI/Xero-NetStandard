using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xero.Api.Core.Model;
using Xero.Api.Infrastructure.Http;

namespace Xero.Api.Core.Endpoints
{
    public interface IAssociationsEndpoint
    {
        Task<Association> FindAsync(Guid fileId, Guid objectId);

        Task<IEnumerable<Association>> FindAsync(Guid fileId);

        Task<IEnumerable<Association>> FindForObjectAsync(Guid objectId);

        Task<Association> CreateAsync(Association association);

        Task DeleteAsync(Association association);
    }

    public class AssociationsEndpoint : IAssociationsEndpoint
    {
        public XeroHttpClient Client { get; private set; }

        internal AssociationsEndpoint(XeroHttpClient client)
        {
            Client = client;
        }

        public async Task<Association> FindAsync(Guid fileId, Guid objectId)
        {
            var endpoint = string.Format("files.xro/1.0/Files/{0}/Associations/{1}", fileId, objectId);

            var response = await Client.GetAsync(endpoint, null);

            return await HandleAssociationResponseAsync(response);
        }

        public async Task<IEnumerable<Association>> FindAsync(Guid fileId)
        {
            var endpoint = string.Format("files.xro/1.0/Files/{0}/Associations", fileId);
            var response = await Client.GetAsync(endpoint, null);

            return await HandleAssociationsResponseAsync(response);
        }

        public async Task<IEnumerable<Association>> FindForObjectAsync(Guid objectId)
        {
            var endpoint = string.Format("files.xro/1.0/Associations/{0}", objectId);
            var response = await Client.GetAsync(endpoint, null);

            return await HandleAssociationsResponseAsync(response);
        }

        public async Task<Association> CreateAsync(Association association)
        {
            var endpoint = string.Format("files.xro/1.0/Files/{0}/Associations", association.FileId);
            var response = await Client.PostAsync(endpoint, association, true);

            return await HandleAssociationResponseAsync(response);
        }

        public async Task DeleteAsync(Association association)
        {
            var endpoint = string.Format("files.xro/1.0/Files/{0}/Associations/{1}", association.FileId, association.ObjectId);
            var response = await Client.DeleteAsync(endpoint);

            await HandleAssociationResponseAsync(response);
        }

        private async Task<IEnumerable<Association>> HandleAssociationsResponseAsync(HttpResponseMessage response)
        {
            var body = await response.Content.ReadAsStringAsync();

            if (response.StatusCode == HttpStatusCode.OK
                || response.StatusCode == HttpStatusCode.Created
                || response.StatusCode == HttpStatusCode.Accepted)
            {
                return Client.JsonMapper.From<IEnumerable<Association>>(body);
            }
            await Client.HandleErrorsAsync(response);
            return null;
        }

        private async Task<Association> HandleAssociationResponseAsync(HttpResponseMessage response)
        {
            var body = await response.Content.ReadAsStringAsync();

            if (response.StatusCode == HttpStatusCode.OK
                || response.StatusCode == HttpStatusCode.Created
                || response.StatusCode == HttpStatusCode.Accepted)
            {
                return Client.JsonMapper.From<Association>(body);
            }
            await Client.HandleErrorsAsync(response);
            return null;
        }
    }
}