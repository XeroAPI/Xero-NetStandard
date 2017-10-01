using System.Runtime.Serialization;

namespace Xero.Api.Payroll.America.Model.Types
{
    // I'm sure there are more but I found these in the documentation
    [DataContract(Namespace = "", Name = "DeductionCategory")]
    public enum DeductionCategoryType
    {
        [EnumMember(Value = "UNKNOWN")]
        Unkown = 0,
        [EnumMember(Value = "AFTERTAXDEDUCTION")]
        AfterTaxDeduction,
        [EnumMember(Value = "DEPENDENTCARE")]
        DependentCare,
        [EnumMember(Value = "FLEXIBLESPENDINGACCOUNT")]
        FlexibleSpendingAccount,
        [EnumMember(Value = "HSASINGLEPLAN")]
        HsaSinglePlan,
        [EnumMember(Value = "HSAFAMILYPLAN")]
        HsaFamilyPlan,
        [EnumMember(Value = "SECTION125PLAN")]
        Section125Plan,
        [EnumMember(Value = "401KRETIREMENTPLAN")]
        FourZeroOneKRetirementPlan
    }
}