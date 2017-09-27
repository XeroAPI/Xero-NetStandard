using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Xero.Api.Payroll.Australia.Model
{
    [DataContract(Namespace = "")]
    public class PayRun : Common.Model.PayRun
    {
        [DataMember(Name = "PayrollCalendarID")]
        public Guid PayrollCalendarId { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string PayslipMessage { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public bool Unscheduled { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public decimal? Wages { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public decimal? Super { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public List<Payslip> Payslips { get; set; }        
    }
}