using System.Runtime.Serialization;

namespace Xero.Api.Payroll.America.Model.Types
{
    // I'm sure there are more but I found these in the documentation
    [DataContract(Namespace = "", Name = "EarningsCategory")]
    public enum EarningsCategoryType
    {
        [EnumMember(Value = "UNKNOWN")]
        Unkown = 0,
        [EnumMember(Value = "REGULAREARNINGS")]
        RegularEarnings,
        [EnumMember(Value = "OVERTIMEEARNINGS")]
        OverTimeEarnings,
        [EnumMember(Value = "ALLOWANCE")]
        Allowance,
        [EnumMember(Value = "ADDITIONALEARNINGS")]
        AdditionalEarnings,
        [EnumMember(Value = "COMMISSION")]
        Commission,
        [EnumMember(Value = "BONUS")]
        Bonus,
        [EnumMember(Value = "CASHTIPS")]
        CashTips,
        [EnumMember(Value = "NONCASHTIPS")]
        NonCashTips,
        [EnumMember(Value = "RETROACTIVEPAY")]
        RetroactivePay,
        [EnumMember(Value = "CLERGYHOUSINGALLOWANCE")]
        ClergyHousingAllowance,
        [EnumMember(Value = "CLERGYHOUSINGINKIND")]
        ClergyHousingInKind
    }
}