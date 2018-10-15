using System.Runtime.Serialization;

namespace Xero.Api.Core.Model.Types
{
    [DataContract(Namespace = "")]
    public enum OrganisationEdition
    {
        [EnumMember(Value = "NONE")]
        None,
        [EnumMember(Value = "BUSINESS")]
        Business,
        [EnumMember(Value = "PARTNER")]
        Partner
    }
}