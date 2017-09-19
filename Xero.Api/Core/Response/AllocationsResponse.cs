using System.Collections.Generic;
using System.Runtime.Serialization;
using Xero.Api.Common;

namespace Xero.Api.Core.Response
{
    public class AllocationsResponse<T> : XeroResponse<T>
    {
        [DataMember]
        public List<T> Allocations { get; set; }

        public override IList<T> Values
        {
            get { return Allocations; }
        }
    }
}