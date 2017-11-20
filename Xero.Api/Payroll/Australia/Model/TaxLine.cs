using System;
using System.Runtime.Serialization;

namespace Xero.Api.Payroll.Australia.Model
{
    [DataContract(Namespace = "")]
    public class TaxLine
    {
        [DataMember(Name = "PayslipTaxLineID")]
        public Guid PayslipTaxLineId { get; set; }

        [DataMember]
        public string TaxTypeName { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public decimal? Amount { get; set; }

        [DataMember]
        public string LiabilityAccount { get; set; }
    }
}