using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Xero.Api.Common;
using Xero.Api.Payroll.Australia.Model.Status;

namespace Xero.Api.Payroll.Australia.Model
{
    [DataContract(Namespace = "")]
    public class Timesheet : HasUpdatedDate
    {
        [DataMember(Name = "TimesheetID", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        [DataMember(Name = "EmployeeID")]
        public Guid EmployeeId { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public DateTime? StartDate { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public DateTime? EndDate { get; set; }

        [DataMember]
        public TimesheetStatus Status { get; set; }

        [DataMember]
        public decimal? Hours { get; set; }

        [DataMember]
        public List<TimesheetLine> TimesheetLines { get; set; }
    }
}
