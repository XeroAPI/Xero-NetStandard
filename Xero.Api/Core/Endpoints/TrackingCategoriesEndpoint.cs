using System.Collections.Generic;
using System.Linq;
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
    public interface ITrackingCategoriesEndpoint : IXeroUpdateEndpoint<TrackingCategoriesEndpoint, TrackingCategory, TrackingCategoriesRequest, TrackingCategoriesResponse>
    {
        TrackingCategoriesEndpoint IncludeArchived(bool include);
        Task<List<Option>> AddOptionAsync(TrackingCategory trackingCategory, Option option);
        Task<List<Option>> UpdateOptionAsync(TrackingCategory trackingCategory, Option option);
        Task DeleteAsync(TrackingCategory trackingCategory);
        Task<Option> DeleteTrackingOptionAsync(TrackingCategory trackingCategory, Option option);
    }

    public class TrackingCategoriesEndpoint : XeroUpdateEndpoint<TrackingCategoriesEndpoint, TrackingCategory, TrackingCategoriesRequest, TrackingCategoriesResponse>, ITrackingCategoriesEndpoint
    {
        public TrackingCategoriesEndpoint(XeroHttpClient client) :
            base(client, "/api.xro/2.0/TrackingCategories")
        {
        }

        public TrackingCategoriesEndpoint IncludeArchived(bool include)
        {
            return include ? AddParameter("includeArchived", true) : this;
        }

        public async Task<List<Option>> AddOptionAsync(TrackingCategory trackingCategory, Option option)
        {
            return await AddOptionsAsync(trackingCategory, new List<Option> {option}).ConfigureAwait(false);
        }

        public async Task DeleteAsync(TrackingCategory trackingCategory)
        {
            var endpoint = string.Format("/api.xro/2.0/trackingcategories/{0}/", trackingCategory.Id);

            var response = await Client.DeleteAsync(endpoint).ConfigureAwait(false);

            await HandleOptionsResponseAsync(response).ConfigureAwait(false);
        }

        public async Task<List<Option>> AddOptionsAsync(TrackingCategory trackingCategory, List<Option> options)
        {
            var endpoint = string.Format("/api.xro/2.0/trackingcategories/{0}/options", trackingCategory.Id);

            var response = await Client.PutAsync(endpoint, options).ConfigureAwait(false);

            var result = await HandleOptionsResponseAsync(response).ConfigureAwait(false);
            
            return result.Values.ToList();
        }

        public async Task<List<Option>> UpdateOptionAsync(TrackingCategory trackingCategory, Option option)
        {
            var endpoint = string.Format("/api.xro/2.0/trackingcategories/{0}/options/{1}", trackingCategory.Id, option.Id);

            var response = await Client.PostAsync(endpoint, new List<Option> {option}).ConfigureAwait(false);

            var result = await HandleOptionsResponseAsync(response).ConfigureAwait(false);

            return result.Values.ToList();
        }

        public async Task<Option> DeleteTrackingOptionAsync(TrackingCategory trackingCategory, Option option)
        {
            var endpoint = string.Format("/api.xro/2.0/TrackingCategories/{0}/Options/{1}", trackingCategory.Id, option.Id);

            var response = await Client.DeleteAsync(endpoint).ConfigureAwait(false);

            var track = await HandleOptionsResponseAsync(response).ConfigureAwait(false);

            return track.Values.FirstOrDefault();
        }

        private async Task<OptionsResponse> HandleOptionsResponseAsync(HttpResponseMessage response)
        {
            if (response.StatusCode == HttpStatusCode.OK)
            {
                var body = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

                var result = Client.JsonMapper.From<OptionsResponse>(body);
                return result;
            }

            await Client.HandleErrorsAsync(response).ConfigureAwait(false);

            return null;
        }
    }
}