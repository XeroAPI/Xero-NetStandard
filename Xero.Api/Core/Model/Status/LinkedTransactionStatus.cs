using System.Runtime.Serialization;

namespace Xero.Api.Core.Model.Status
{
    [DataContract(Namespace = "")]
    public enum LinkedTransactionStatus
    {
        [EnumMember(Value = "UNKNOWN")]
        Unkown = 0,
        [EnumMember(Value = "DRAFT")]
        Draft,
        [EnumMember(Value = "APPROVED")]
        Approved,
        [EnumMember(Value = "ONDRAFT")]
        OnDraft,
        [EnumMember(Value = "BILLED")]
        Billed,
        [EnumMember(Value = "VOIDED")]
        Voided
    }
}
