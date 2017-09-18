using System;

namespace Xero.Api.Payroll.Australia.Model
{
    using System.Runtime.Serialization;

    /// <summary>
    /// Earnings Line for a payslip
    /// </summary>
    [DataContract(Namespace = "", Name = "EarningsLine")]
    public class PayslipEarningsLine
    {
        [DataMember(Name = "EarningsRateID")]
        public Guid EarningsRateId { get; set; }

        [DataMember()]
        public decimal? RatePerUnit { get; set; }

        [DataMember()]
        public decimal? NumberOfUnits { get; set; }

        [DataMember(EmitDefaultValue = true)]
        public decimal? FixedAmount { get; set; }
    }
}
