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
        public ItemsEndpoint(XeroHttpClient client) :
            base(client, "/api.xro/2.0/Items")
        {
        }

        public async Task DeleteAsync(Item itemToDelete)
        {
            var endpoint = string.Format("/api.xro/2.0/Items/{0}", itemToDelete.Id);

            var response = await Client.DeleteAsync(endpoint);

            await HandleResponseAsync(response);
        }

        private async Task<ItemsResponse> HandleResponseAsync(HttpResponseMessage response)
        {
            if (response.StatusCode == HttpStatusCode.OK)
            {
                var body = await response.Content.ReadAsStringAsync();

                var result = Client.JsonMapper.From<ItemsResponse>(body);
                return result;
            }

            await Client.HandleErrorsAsync(response);

            return null;
        }
    }
}