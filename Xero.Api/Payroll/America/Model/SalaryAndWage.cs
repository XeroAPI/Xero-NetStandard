using System;
using System.Runtime.Serialization;
using Xero.Api.Payroll.America.Model.Types;

namespace Xero.Api.Payroll.America.Model
{
    [DataContract(Namespace = "")]
    public class SalaryAndWage
    {
        [DataMember(Name = "SalaryAndWagesID", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        [DataMember(Name = "EarningsTypeID")]
        public Guid EarningsTypeId { get; set; }

        [DataMember]
        public SalaryWagesType SalaryWagesType { get; set; }

        [DataMember]
        public decimal? HourlyRate { get; set; }

        [DataMember]
        public decimal? AnnualSalary { get; set; }

        [DataMember]
        public decimal? StandardHoursPerWeek { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public DateTime? EffectiveDate { get; set; }
    }
}