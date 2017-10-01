using System.Runtime.Serialization;

namespace Xero.Api.Core.Model.Types
{
    [DataContract(Namespace = "")]
    public enum AccountClassType
    {
        [EnumMember(Value = "UNKNOWN")]
        Unkown = 0,
        [EnumMember(Value = "ASSET")]
        Asset,
        [EnumMember(Value = "EQUITY")]
        Equity,
        [EnumMember(Value = "EXPENSE")]
        Expense,
        [EnumMember(Value = "LIABILITY")]
        Liability,
        [EnumMember(Value = "REVENUE")]
        Revenue,
    }
}
