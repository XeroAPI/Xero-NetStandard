using System;
using System.Runtime.Serialization;
using Xero.Api.Common;
using Xero.Api.Payroll.Australia.Model.Types;

namespace Xero.Api.Payroll.Australia.Model
{
    [DataContract(Namespace = "")]
    public class EarningsRate : HasUpdatedDate
    {
        [DataMember(Name = "EarningsRateID", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public EarningsType EarningsType { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public RateType RateType { get; set; }

        [DataMember]
        public string AccountCode { get; set; }

        [DataMember]
        public string TypeOfUnits { get; set; }
        
        [DataMember]
        public bool IsExemptFromTax { get; set; }

        [DataMember]
        public bool IsExemptFromSuper { get; set; }

        [DataMember]
        public bool IsReportableAsW1 { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public decimal? RatePerUnit { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public decimal? Multiplier { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public decimal? Amount { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public bool AccrueLeave { get; set; }        
    }
}