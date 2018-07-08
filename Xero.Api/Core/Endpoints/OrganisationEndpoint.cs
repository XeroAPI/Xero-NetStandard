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
        internal OrganisationEndpoint(XeroHttpClient client)
            : base(client, "/api.xro/2.0/Organisation")
        {
        }

        public async Task<OrganisationCisSetting> GetCisSettingsAsync(Guid id)
        {
            var organisationCisSettings = await Client.GetAsync<OrganisationCisSetting, OrganisationCisSettingsResponse>($"/api.xro/2.0/organisations/{id}/cissettings").ConfigureAwait(false);

            return organisationCisSettings.FirstOrDefault();
        }
    }
}