using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Xero.Api.Common;
using Xero.Api.Infrastructure.Interfaces;
using Xero.Api.Payroll.America.Model;

namespace Xero.Api.Payroll.America.Request
{
    [DataContract(Namespace = "", Name = "PayItems")]
    public class PayItemsRequest : XeroRequest<PayItems>
    {
        [DataMember(EmitDefaultValue = false)]
        public List<EarningsType> EarningsTypes { get { return PayItems.EarningsTypes; } }

        [DataMember(EmitDefaultValue = false)]
        public List<DeductionType> DeductionTypes { get { return PayItems.DeductionTypes; } }

        [DataMember(EmitDefaultValue = false)]
        public List<TimeOffType> TimeOffTypes { get { return PayItems.TimeOffTypes; } }

        [DataMember(EmitDefaultValue = false)]
        public List<ReimbursementType> ReimbursementTypes { get { return PayItems.ReimbursementTypes; } }

        private PayItems PayItems { get; set; }

        public IList<PayItems> Items { get { return new[] { PayItems }; } }

        public void Add(PayItems value)
        {
            PayItems = value;
        }

        public void AddRange(IEnumerable<PayItems> value)
        {
            PayItems = value.FirstOrDefault();
        }
    }
}