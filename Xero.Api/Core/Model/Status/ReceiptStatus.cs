using System.Runtime.Serialization;

namespace Xero.Api.Core.Model.Status
{
    [DataContract(Namespace = "")]
    public enum ReceiptStatus
    {
        [EnumMember(Value = "UNKNOWN")]
        Unkown = 0,
        [EnumMember(Value = "DRAFT")]
        Draft,
        [EnumMember(Value = "SUBMITTED")]
        Submitted,
        [EnumMember(Value = "AUTHORISED")]
        Authorised,
        [EnumMember(Value = "DECLINED")]
        Declined,
        [EnumMember(Value = "DELETED")]
        Deleted
    }
}