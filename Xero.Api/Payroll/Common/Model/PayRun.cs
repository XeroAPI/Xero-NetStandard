using System;
using System.Runtime.Serialization;
using Xero.Api.Common;
using Xero.Api.Payroll.Common.Model.Status;

namespace Xero.Api.Payroll.Common.Model
{
    [DataContract(Namespace = "")]
    public abstract class PayRun : HasUpdatedDate
    {
        [DataMember(Name = "PayRunID", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        [DataMember]
        public DateTime? PayRunPeriodStartDate { get; set; }

        [DataMember]
        public DateTime? PayRunPeriodEndDate { get; set; }

        [DataMember]
        public PayRunStatus PayRunStatus { get; set; }

        [DataMember]
        public DateTime? PaymentDate { get; set; }

        [DataMember]
        public decimal? Deductions { get; set; }

        [DataMember]
        public decimal? Tax { get; set; }

        [DataMember]
        public decimal? Reimbursement { get; set; }

        [DataMember]
        public decimal? NetPay { get; set; }
    }
}
