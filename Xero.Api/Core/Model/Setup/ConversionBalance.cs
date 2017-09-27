using System.Runtime.Serialization;

namespace Xero.Api.Core.Model.Setup
{
    [DataContract(Namespace = "")]
    public class ConversionBalance
    {
        [DataMember]
        public decimal? Balance { get; set; }

        [DataMember]
        public string AccountCode { get; set; }

        [DataMember]
        public string Type { get; set; }
    }
}