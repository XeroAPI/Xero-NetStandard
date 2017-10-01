using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Xero.Api.Payroll.Australia.Model
{
    [DataContract(Namespace = "")]
    public class PayItems
    {
        [DataMember(Name = "EarningsTypes")]
        public List<EarningsRate> EarningsRates { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public List<DeductionType> DeductionTypes { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public List<LeaveType> LeaveTypes { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public List<ReimbursementType> ReimbursementTypes { get; set; }
    }
}
