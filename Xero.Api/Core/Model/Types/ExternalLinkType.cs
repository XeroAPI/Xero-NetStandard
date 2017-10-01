using System.Runtime.Serialization;

namespace Xero.Api.Core.Model.Types
{
    [DataContract(Namespace = "")]
    public enum ExternalLinkType
    {
        [EnumMember]
        Unkown = 0,
        [EnumMember]
        Website,
        [EnumMember]
        Facebook,
        [EnumMember]
        GooglePlus,
        [EnumMember]
        LinkedIn,
        [EnumMember]
        Twitter,
    }
}