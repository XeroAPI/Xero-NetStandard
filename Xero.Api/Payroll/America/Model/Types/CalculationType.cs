using System.Runtime.Serialization;

namespace Xero.Api.Payroll.America.Model.Types
{
    // I'm sure there are more but I found these in the documentation
    [DataContract(Namespace = "")]
    public enum CalculationType
    {
        [EnumMember(Value = "UNKNOWN")]
        Unkown = 0,
        [EnumMember(Value = "STANDARDAMOUNT")]
        StandardAmount,
        [EnumMember(Value = "PERCENTAGEOFGROSS")]
        PercentageOfGross,
        [EnumMember(Value = "FIXEDAMOUNT")]
        FixedAmount,
        [EnumMember(Value = "CATCHUPPLAN")]
        CatchUpPlan
    }
}