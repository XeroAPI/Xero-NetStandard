using System;
using System.Runtime.Serialization;
using Xero.Api.Payroll.America.Model.Types;

namespace Xero.Api.Payroll.America.Model
{
    [DataContract(Namespace = "")]
    public class DeductionLine
    {
        [DataMember(Name = "DeductionTypeID")]
        public Guid DeductionTypeId { get; set; }

        [DataMember]
        public CalculationType CalculationType { get; set; }

        [DataMember]
        public decimal? EmployeeMax { get; set; }

        [DataMember]
        public decimal? Percentage { get; set; }

        [DataMember]
        public decimal? Amount { get; set; }
    }
}