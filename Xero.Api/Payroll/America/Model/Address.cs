using System.Runtime.Serialization;
using Xero.Api.Payroll.America.Model.Types;

namespace Xero.Api.Payroll.America.Model
{
    [DataContract(Namespace = "")]
    public class Address
    {
        [DataMember]
        public string StreetAddress { get; set; }

        [DataMember]
        public string City { get; set; }

        [DataMember]
        public State State { get; set; }

        [DataMember(Name = "Zip")]
        public int ZipCode { get; set; }

        [DataMember]
        public decimal? Latitude { get; set; }

        [DataMember]
        public decimal? Longitude { get; set; }
    }
}