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
        private readonly string _endpointBase;
        public XeroHttpClient Client { get; private set; }

        public AssociationsEndpoint(XeroHttpClient client)
            : this(client, "/files.xro/1.0")
        {
        }

        public AssociationsEndpoint(XeroHttpClient client, string endpointBase)
        {
            _endpointBase = endpointBase;
            Client = client;
        }

        public async Task<Association> FindAsync(Guid fileId, Guid objectId)
        {
            var endpoint = $"{_endpointBase}/Files/{fileId}/Associations/{objectId}";

            var response = await Client.GetAsync(endpoint, null).ConfigureAwait(false);

            return await HandleAssociationResponseAsync(response).ConfigureAwait(false);
        }

        public async Task<IEnumerable<Association>> FindAsync(Guid fileId)
        {
            var endpoint = $"{_endpointBase}/Files/{fileId}/Associations";
            var response = await Client.GetAsync(endpoint, null).ConfigureAwait(false);

            return await HandleAssociationsResponseAsync(response).ConfigureAwait(false);
        }

        public async Task<IEnumerable<Association>> FindForObjectAsync(Guid objectId)
        {
            var endpoint = $"{_endpointBase}/Associations/{objectId}";
            var response = await Client.GetAsync(endpoint, null).ConfigureAwait(false);

            return await HandleAssociationsResponseAsync(response).ConfigureAwait(false);
        }

        public async Task<Association> CreateAsync(Association association)
        {
            var endpoint = $"{_endpointBase}/Files/{association.FileId}/Associations";
            var response = await Client.PostAsync(endpoint, association, true).ConfigureAwait(false);

            return await HandleAssociationResponseAsync(response).ConfigureAwait(false);
        }

        public async Task DeleteAsync(Association association)
        {
            var endpoint = $"{_endpointBase}/Files/{association.FileId}/Associations/{association.ObjectId}";
            var response = await Client.DeleteAsync(endpoint).ConfigureAwait(false);

            await HandleAssociationResponseAsync(response).ConfigureAwait(false);
        }

        private async Task<IEnumerable<Association>> HandleAssociationsResponseAsync(HttpResponseMessage response)
        {
            var body = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            if (response.StatusCode == HttpStatusCode.OK
                || response.StatusCode == HttpStatusCode.Created
                || response.StatusCode == HttpStatusCode.Accepted)
            {
                return Client.JsonMapper.From<IEnumerable<Association>>(body);
            }
            await Client.HandleErrorsAsync(response).ConfigureAwait(false);
            return null;
        }

        private async Task<Association> HandleAssociationResponseAsync(HttpResponseMessage response)
        {
            var body = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            if (response.StatusCode == HttpStatusCode.OK
                || response.StatusCode == HttpStatusCode.Created
                || response.StatusCode == HttpStatusCode.Accepted)
            {
                return Client.JsonMapper.From<Association>(body);
            }
            await Client.HandleErrorsAsync(response).ConfigureAwait(false);
            return null;
        }
    }
}