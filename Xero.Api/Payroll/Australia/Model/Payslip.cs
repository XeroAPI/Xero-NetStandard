using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Xero.Api.Payroll.Common.Model;

namespace Xero.Api.Payroll.Australia.Model
{
    [DataContract(Namespace = "")]
    public class Payslip : PayNotice
    {
        [DataMember(Name = "PayslipID", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        [DataMember]
        public string EmployeeGroup { get; set; }

        [DataMember]
        public DateTime? LastEdited { get; set; }

        [DataMember]
        public decimal? Super { get; set; }

        [DataMember]
        public decimal? Wages { get; set; }

        [DataMember]
        public List<PayslipEarningsLine> EarningsLines { get; set; }

        [DataMember]
        public List<DeductionLine> DeductionLines { get; set; }

        [DataMember]
        public List<ReimbursementLine> ReimbursementLines { get; set; }

        [DataMember]
        public List<LeaveEarningsLine> LeaveEarningsLines { get; set; }

        [DataMember]
        public List<TimesheetEarningsLine> TimesheetEarningsLines { get; set; }

        [DataMember]
        public List<LeaveAccrualLine> LeaveAccrualLines { get; set; }

        [DataMember]
        public List<SuperannuationLine> SuperannuationLines { get; set; }

        [DataMember]
        public List<TaxLine> TaxLines { get; set; }

        [DataMember(EmitDefaultValue = false, Name = "PayRunID")]
        public Guid PayRunId { get; set; }

    }
}