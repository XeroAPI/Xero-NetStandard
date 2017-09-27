using System.Runtime.Serialization;
using Xero.Api.Common;

namespace Xero.Api.Core.Model
{
    [DataContract(Namespace = "")]
    public abstract class ItemDetails : HasUpdatedDate
    {
        [DataMember(EmitDefaultValue = false)]
        public decimal? UnitPrice { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string AccountCode { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string TaxType { get; set; }
    }
}
