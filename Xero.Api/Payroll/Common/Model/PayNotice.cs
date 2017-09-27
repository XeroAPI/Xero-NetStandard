using System;
using System.Runtime.Serialization;
using Xero.Api.Common;

namespace Xero.Api.Payroll.Common.Model
{
    [DataContract(Namespace = "")]
    public abstract class PayNotice : HasUpdatedDate
    {
        [DataMember(Name = "EmployeeID", EmitDefaultValue = false)]
        public Guid EmployeeId { get; set; }

        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string LastName { get; set; }

        [DataMember]
        public decimal? Deductions { get; set; }

        [DataMember]
        public decimal? Tax { get; set; }

        [DataMember]
        public decimal? Reimbursements { get; set; }

        [DataMember]
        public decimal? NetPay { get; set; }
    }
}
