using System;
using System.Runtime.Serialization;
using Xero.Api.Payroll.Australia.Model.Types;

namespace Xero.Api.Payroll.Australia.Model
{
    [DataContract(Namespace = "")]
    public class DeductionLine
    {
        [DataMember(Name = "DeductionTypeID")]
        public Guid DeductionTypeId { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public decimal? Amount { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public DeductionCalculationType? CalculationType { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public decimal? NumberOfUnits { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public decimal? Percentage { get; set; }
    }    
}
