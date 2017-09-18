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
    public interface ITrackingCategoriesEndpoint : IXeroUpdateEndpoint<TrackingCategoriesEndpoint, TrackingCategory, TrackingCategoriesRequest, TrackingCategoriesResponse>
    {
        IOptionCollection this[Guid id] { get; }
        List<TrackingCategory> GetAll();
        TrackingCategoriesEndpoint IncludeArchived(bool include);
        TrackingCategory GetByID(Guid id);
        TrackingCategory Delete(TrackingCategory trackingCategory);
        Option DeleteTrackingOption(TrackingCategory trackingCategory, Option option);
        TrackingCategory Add(TrackingCategory trackingCategory);
    }

    public class TrackingCategoriesEndpoint : XeroUpdateEndpoint<TrackingCategoriesEndpoint, TrackingCategory, TrackingCategoriesRequest, TrackingCategoriesResponse>, ITrackingCategoriesEndpoint
    {
        public TrackingCategoriesEndpoint(XeroHttpClient client) :
            base(client, "/api.xro/2.0/TrackingCategories")
        {
        }

        public TrackingCategoriesEndpoint IncludeArchived(bool include)
        {
            if (include)
            {
                AddParameter("includeArchived", true);
            }

            return this;
        }

        public IOptionCollection this[Guid id]
        {
            get
            {
                var endpoint = string.Format("/api.xro/2.0/TrackingCategories/{0}", id);

                var trackingCat = HandleResponse(Client.Get(endpoint, null)).TrackingCategories.FirstOrDefault();

                var collection = new OptionCollection(Client, trackingCat);

                return collection;
            }
        }

        public TrackingCategory GetByID(Guid id)
        {
            var endpoint = string.Format("/api.xro/2.0/TrackingCategories/{0}", id);

            var trackingCat = HandleResponse(Client.Get(endpoint, null)).TrackingCategories.FirstOrDefault();

            return trackingCat;
        }

        public List<TrackingCategory> GetAll()
        {
            var endpoint = string.Format("/api.xro/2.0/TrackingCategories");

            List<TrackingCategory> trackingCats = HandleResponse(Client.Get(endpoint, QueryString)).TrackingCategories.ToList();

            return trackingCats;
        } 

        public TrackingCategory Add(TrackingCategory trackingCategory)
        {
            var endpoint = string.Format("/api.xro/2.0/TrackingCategories");

            var groups = HandleResponse(Client
                .Put(endpoint, new List<TrackingCategory> { trackingCategory }))
                .Values;

            return groups.FirstOrDefault();
        }

        public override TrackingCategory Update(TrackingCategory trackingCategory)
        {
            var endpoint = string.Format("/api.xro/2.0/TrackingCategories/{0}", trackingCategory.Id.ToString());

            trackingCategory.Options = null;

            var groups = HandleResponse(Client
                .Post(endpoint, new List<TrackingCategory> { trackingCategory }))
                .Values;

            return groups.FirstOrDefault();
        }

        public TrackingCategory Delete(TrackingCategory trackingCategory)
        {
            var endpoint = string.Format("/api.xro/2.0/TrackingCategories/{0}", trackingCategory.Id);

            var track = HandleResponse(Client
                .Delete(endpoint));

            return track.Values.FirstOrDefault();
        }

        public Option DeleteTrackingOption(TrackingCategory trackingCategory, Option option)
        {
            var endpoint = string.Format("/api.xro/2.0/TrackingCategories/{0}/Options/{1}", trackingCategory.Id, option.Id);

            var track = HandleOptionResponse(Client
                .Delete(endpoint));

            return track.Values.FirstOrDefault();
        }

        private TrackingCategoriesResponse HandleResponse(HttpResponseMessage response)
        {
            if (response.StatusCode == HttpStatusCode.OK)
            {
                var body = response.Content.ReadAsStringAsync().Result;

                var result = Client.JsonMapper.From<TrackingCategoriesResponse>(body);
                return result;
            }

            Client.HandleErrors(response);

            return null;
        }

        private OptionsResponse HandleOptionResponse(HttpResponseMessage response)
        {
            if (response.StatusCode == HttpStatusCode.OK)
            {
                var body = response.Content.ReadAsStringAsync().Result;

                var result = Client.JsonMapper.From<OptionsResponse>(body);
                return result;
            }

            Client.HandleErrors(response);

            return null;
        }
    }

    public interface IOptionCollection :
        IXeroUpdateEndpoint
            <TrackingCategoriesEndpoint, TrackingCategory, TrackingCategoriesRequest, TrackingCategoriesResponse>
    {
        List<Option> Add(Option option);
        List<Option> Add(List<Option> options);
        Option UpdateOption(Option option);
    }

    public class OptionCollection :
        XeroUpdateEndpoint<TrackingCategoriesEndpoint, TrackingCategory, TrackingCategoriesRequest, TrackingCategoriesResponse>, IOptionCollection
    {
        public TrackingCategory _trackingCat;
        private readonly XeroHttpClient _client;

        public OptionCollection(XeroHttpClient client, TrackingCategory trackingCat)
            : base(client, "/api.xro/2.0/TrackingCategories")
        {
            _trackingCat = trackingCat;
            _client = client;
        }

        public List<Option> Add(Option option)
        {
            List<Option> options = new List<Option>();
 
            options.Add(option);

            return AssignOptions(_trackingCat, options); ;
        }

        public List<Option> Add(List<Option> options)
        {
            return AssignOptions(_trackingCat, options);
        }

        private List<Option> AssignOptions(TrackingCategory category, List<Option> options)
        {
            var endpoint = string.Format("/api.xro/2.0/trackingcategories/{0}/options", category.Id);

            var result = HandleResponse(_client
                 .Put(endpoint, _client.XmlMapper.To(options))).Values.ToList();

            return result;
        }

        private OptionsResponse HandleResponse(HttpResponseMessage response)
        {
            if (response.StatusCode == HttpStatusCode.OK)
            {
                var body = response.Content.ReadAsStringAsync().Result;

                var result = Client.JsonMapper.From<OptionsResponse>(body);
                return result;
            }

            Client.HandleErrors(response);

            return null;
        }

        public Option UpdateOption(Option option)
        {
            var endpoint = string.Format("/api.xro/2.0/trackingcategories/{0}/options/{1}", _trackingCat.Id, option.Id);


            List<Option> Options = new List<Option>();
            Options.Add(option);
            
            var result = HandleResponse(_client
                 .Post(endpoint, Options)).Options.FirstOrDefault();

            return result;
        }
    }
}