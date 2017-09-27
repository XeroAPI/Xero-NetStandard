using System;
using System.Runtime.Serialization;
using Xero.Api.Payroll.Australia.Model.Status;

namespace Xero.Api.Payroll.Australia.Model
{
    [DataContract(Namespace = "")]
    public class LeavePeriod
    {
        [DataMember]
        public DateTime? PayPeriodStartDate { get; set; }

        [DataMember]
        public DateTime? PayPeriodEndDate { get; set; }

        [DataMember]
        public LeavePeriodStatus LeavePeriodStatus { get; set; }

        [DataMember]
        public decimal? NumberOfUnits { get; set; }
    }
}
