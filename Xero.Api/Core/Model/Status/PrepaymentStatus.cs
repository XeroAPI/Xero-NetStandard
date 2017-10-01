using System.Runtime.Serialization;

namespace Xero.Api.Core.Model.Status
{
    [DataContract(Namespace = "")]
    public enum PrepaymentStatus
    {
        [EnumMember(Value = "UNKNOWN")]
        Unkown = 0,
        [EnumMember(Value = "AUTHORISED")]
        Authorised,
        [EnumMember(Value = "PAID")]
        Paid,
        [EnumMember(Value = "VOIDED")]
        Voided
    }
}