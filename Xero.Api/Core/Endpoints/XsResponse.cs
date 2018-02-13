using System.Collections.Generic;
using Xero.Api.Common;

namespace Xero.Api.Core.Endpoints
{
    public class XsResponse : XeroResponse<X>
    {
        public List<X> Xs { get; set; }

        public override IList<X> Values
        {
            get { return Xs; }
        }
    }
}