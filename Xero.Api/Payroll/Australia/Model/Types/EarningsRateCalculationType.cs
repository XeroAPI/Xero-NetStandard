using System.Runtime.Serialization;

namespace Xero.Api.Payroll.Australia.Model.Types
{
    [DataContract(Namespace = "")]
    public enum EarningsRateCalculationType
    {
        [EnumMember(Value = "UNKNOWN")]
        Unkown = 0,
        [EnumMember(Value = "USEEARNINGSRATE")]
        UseEarningsRate,
        [EnumMember(Value = "ENTEREARNINGSRATE")]
        EnterEarningsRate,
        [EnumMember(Value = "ANNUALSALARY")]
        AnnualSalary
    }
}