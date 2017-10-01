using System.Runtime.Serialization;

namespace Xero.Api.Core.Model.Status
{
    public enum OrganisationStatus
    {
        [EnumMember(Value = "UNKNOWN")]
        Unkown = 0,
        [EnumMember(Value = "ACTIVE")]
        Active
    }
}