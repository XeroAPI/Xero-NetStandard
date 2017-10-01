using System.Runtime.Serialization;

namespace Xero.Api.Core.Model.Status
{
    public enum PaymentStatus
    {
        [EnumMember(Value = "UNKNOWN")]
        Unkown = 0,
        [EnumMember(Value = "AUTHORISED")]
        Authorised,
        [EnumMember(Value = "DELETED")]
        Deleted
    }
}