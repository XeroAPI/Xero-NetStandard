using System.Collections.Generic;
using Xero.Api.Common;
using Xero.Api.Core.Model;

namespace Xero.Api.Core.Response
{
    public class OrganisationCisSettingsResponse : XeroResponse<OrganisationCisSetting>
    {
        public List<OrganisationCisSetting> OrganisationCisSettings { get; set; }

        public override IList<OrganisationCisSetting> Values
        {
            get { return OrganisationCisSettings; }
        }
    }
}