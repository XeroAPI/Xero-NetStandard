using System;
using System.Linq;
using System.Threading.Tasks;
using Xero.Api.Common;
using Xero.Api.Core.Model;
using Xero.Api.Core.Response;
using Xero.Api.Infrastructure.Http;

namespace Xero.Api.Core.Endpoints
{
    public interface IOrganisationEndpoint : IXeroReadEndpoint<OrganisationEndpoint, Organisation, OrganisationResponse>
    {
        Task<OrganisationCisSetting> GetCisSettingsAsync(Guid id);
    }

    public class OrganisationEndpoint : XeroReadEndpoint<OrganisationEndpoint, Organisation, OrganisationResponse>, IOrganisationEndpoint
    {
        private readonly string _endpointBase;

        public OrganisationEndpoint(XeroHttpClient client)
            : this(client, "/api.xro/2.0")
        {
        }

        public OrganisationEndpoint(XeroHttpClient client, string endpointBase)
            : base(client, $"{endpointBase}/Organisation")
        {
            _endpointBase = endpointBase;
        }

        public async Task<OrganisationCisSetting> GetCisSettingsAsync(Guid id)
        {
            var organisationCisSettings = await Client.GetAsync<OrganisationCisSetting, OrganisationCisSettingsResponse>($"{_endpointBase}/organisations/{id}/cissettings").ConfigureAwait(false);

            return organisationCisSettings.FirstOrDefault();
        }
    }
}