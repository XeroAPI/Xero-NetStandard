using System.Runtime.Serialization;

namespace Xero.Api.Core.Model.Status
{
    [DataContract(Namespace = "")]
    public enum TrackingCategoryStatus
    {
        [EnumMember(Value = "UNKNOWN")]
        Unkown = 0,
        [EnumMember(Value = "ACTIVE")]
        Active,
        [EnumMember(Value = "ARCHIVED")]
        Archived,
        [EnumMember(Value = "DELETED")]
        Deleted
    }
}