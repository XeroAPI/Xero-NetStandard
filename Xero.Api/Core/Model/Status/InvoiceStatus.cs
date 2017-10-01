using System.Runtime.Serialization;

namespace Xero.Api.Core.Model.Status
{
    [DataContract(Namespace = "")]
    public enum InvoiceStatus
    {
        [EnumMember(Value = "UNKNOWN")]
        Unkown = 0,
        [EnumMember(Value = "DRAFT")]
        Draft,
        [EnumMember(Value = "SUBMITTED")]
        Submitted,
        [EnumMember(Value = "DELETED")]
        Deleted,
        [EnumMember(Value = "AUTHORISED")]
        Authorised,
        [EnumMember(Value = "PAID")]
        Paid,
        [EnumMember(Value = "VOIDED")]
        Voided        
    }
}