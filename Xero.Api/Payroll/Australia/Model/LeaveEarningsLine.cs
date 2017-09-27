using System;
using System.Runtime.Serialization;

namespace Xero.Api.Payroll.Australia.Model
{
    [DataContract(Namespace = "")]
    public class LeaveEarningsLine
    {
        [DataMember(Name = "EarningsRateId", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        [DataMember]
        public decimal? RatePerUnit { get; set; }

        [DataMember]
        public decimal? NumberOfUnits { get; set; }
    }
}