using System;
using System.Runtime.Serialization;
using Xero.Api.Payroll.America.Model.Types;

namespace Xero.Api.Payroll.America.Model
{
    [DataContract(Namespace = "")]
    public class BenefitLine
    {
        [DataMember(Name = "BenefitTypeID")]
        public Guid BenefitTypeId { get; set; }

        [DataMember]
        public CalculationType CalculationType { get; set; }

        [DataMember]
        public decimal? Amount { get; set; }
    }
}