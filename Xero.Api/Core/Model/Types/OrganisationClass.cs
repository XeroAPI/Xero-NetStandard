using System.Runtime.Serialization;

namespace Xero.Api.Core.Model.Types
{
    [DataContract(Namespace = "")]
    public enum OrganisationClass
    {
        [EnumMember(Value = "NONE")]
        None,
        [EnumMember(Value = "DEMO")]
        Demo,
        [EnumMember(Value = "TRIAL")]
        Trial,
        [EnumMember(Value = "STARTER")]
        Starter,
        [EnumMember(Value = "STANDARD")]
        Standard,
        [EnumMember(Value = "PREMIUM")]
        Premium,
        [EnumMember(Value = "PREMIUM_20")]
        Premium20,
        [EnumMember(Value = "PREMIUM_50")]
        Premium50,
        [EnumMember(Value = "PREMIUM_100")]
        Premium100,
        [EnumMember(Value = "LEDGER")]
        Ledger,
        [EnumMember(Value = "GST_CASHBOOK")]
        GstCashbook,
        [EnumMember(Value = "NON_GST_CASHBOOK")]
        NonGstCashbook
    }
}