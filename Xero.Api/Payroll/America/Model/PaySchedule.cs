using System;
using System.Runtime.Serialization;
using Xero.Api.Common;
using Xero.Api.Payroll.America.Model.Types;

namespace Xero.Api.Payroll.America.Model
{
    [DataContract(Namespace = "")]
    public class PaySchedule : HasUpdatedDate
    {
        [DataMember(Name = "PayScheduleID", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        [DataMember(Name = "PayScheduleName")]
        public string Name { get; set; }
        
        [DataMember(EmitDefaultValue = false)]
        public DateTime? PaymentDate { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public DateTime? StartDate { get; set; }

        [DataMember]
        public ScheduleType ScheduleType { get; set; }
    }
}