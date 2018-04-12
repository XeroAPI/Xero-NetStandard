using System.Collections.Generic;
using Xero.Api.Common;
using Xero.Api.Core.Model;

namespace Xero.Api.Core.Response
{
    public class ContactCisSettingsResponse : XeroResponse<ContactCisSetting>
    {
        public List<ContactCisSetting> ContactCisSettings { get; set; }

        public override IList<ContactCisSetting> Values
        {
            get { return ContactCisSettings; }
        }
    }
}