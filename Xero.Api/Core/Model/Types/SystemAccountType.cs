using System.Runtime.Serialization;

namespace Xero.Api.Core.Model.Types
{
    [DataContract(Namespace = "")]
    public enum SystemAccountType
    {
        [EnumMember(Value = "UNKNOWN")]
        Unkown = 0,
        [EnumMember(Value = "DEBTORS")]
        Debtors,
        [EnumMember(Value = "CREDITORS")]
        Creditors,
        [EnumMember(Value = "BANKCURRENCYGAIN")]
        BankCurrencyGain,
        [EnumMember(Value = "GST")]
        GST,
        [EnumMember(Value = "GSTONIMPORTS")]
        GSTOnImports,
        [EnumMember(Value = "HISTORICAL")]
        Historical,
        [EnumMember(Value = "REALISEDCURRENCYGAIN")]
        RealisedCurrencyGain,
        [EnumMember(Value = "RETAINEDEARNINGS")]
        RetainedEarnings,
        [EnumMember(Value = "ROUNDING")]
        Rounding,
        [EnumMember(Value = "TRACKINGTRANSFERS")]
        TrackingTransfers,
        [EnumMember(Value = "UNPAIDEXPCLM")]
        UnpaidExpenseClaim,
        [EnumMember(Value = "UNREALISEDCURRENCYGAIN")]
        UnrealisedCurrencyGain,
        [EnumMember(Value = "WAGEPAYABLES")]
        WagePayables,
    } 
}
