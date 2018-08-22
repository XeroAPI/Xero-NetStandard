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
    public interface IItemsEndpoint : IXeroUpdateEndpoint<ItemsEndpoint, Item, ItemsRequest, ItemsResponse>
    {
        Task DeleteAsync(Item itemToDelete);
    }

    public class ItemsEndpoint
        : FourDecimalPlacesEndpoint<ItemsEndpoint, Item, ItemsRequest, ItemsResponse>, IItemsEndpoint
    {
        private readonly string _endpointBase;

        public ItemsEndpoint(XeroHttpClient client) :
            this(client, "/api.xro/2.0")
        {
        }

        public ItemsEndpoint(XeroHttpClient client, string endpointBase) :
            base(client, $"{endpointBase}/Items")
        {
            _endpointBase = endpointBase;
        }

        public async Task DeleteAsync(Item itemToDelete)
        {
            var endpoint = $"{_endpointBase}/Items/{itemToDelete.Id}";

            var response = await Client.DeleteAsync(endpoint).ConfigureAwait(false);

            await HandleResponseAsync(response).ConfigureAwait(false);
        }

        private async Task<ItemsResponse> HandleResponseAsync(HttpResponseMessage response)
        {
            if (response.StatusCode == HttpStatusCode.OK)
            {
                var body = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

                var result = Client.JsonMapper.From<ItemsResponse>(body);
                return result;
            }

            await Client.HandleErrorsAsync(response).ConfigureAwait(false);

            return null;
        }
    }
}