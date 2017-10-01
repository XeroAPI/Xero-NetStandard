using System.Runtime.Serialization;

namespace Xero.Api.Core.Model.Types
{
    [DataContract(Namespace = "")]
    public enum AccountType
    {
        [EnumMember(Value = "UNKNOWN")]
        Unkown = 0,
        [EnumMember(Value = "NONE")]
        None,
        [EnumMember(Value = "BANK")]
        Bank,
        [EnumMember(Value = "CURRENT")]
        Current,
        [EnumMember(Value = "CURRLIAB")]
        CurrentLiability,
        [EnumMember(Value = "DEPRECIATN")]
        Depreciation,
        [EnumMember(Value = "DIRECTCOSTS")]
        DirectCosts,
        [EnumMember(Value = "EQUITY")]
        Equity,
        [EnumMember(Value = "EXPENSE")]
        Expense,
        [EnumMember(Value = "FIXED")]
        Fixed,
        [EnumMember(Value = "INVENTORY")]
        Inventory,
        [EnumMember(Value = "LIABILITY")]
        Liability,
        [EnumMember(Value = "NONCURRENT")]
        NonCurrent,
        [EnumMember(Value = "OTHERINCOME")]
        OtherIncome,
        [EnumMember(Value = "OVERHEADS")]
        Overheads,
        [EnumMember(Value = "PREPAYMENT")]
        Prepayment,
        [EnumMember(Value = "REVENUE")]
        Revenue,
        [EnumMember(Value = "SALES")]
        Sales,
        [EnumMember(Value = "TERMLIAB")]
        TermLiability,
        [EnumMember(Value = "PAYGLIABILITY")]
        PayGLiability,
        [EnumMember(Value = "SUPERANNUATIONEXPENSE")]
        SuperannuationExpense,
        [EnumMember(Value = "SUPERANNUATIONLIABILITY")]
        SuperannuationLiability,
        [EnumMember(Value = "WAGESEXPENSE")]
        WagesExpense
    }
}