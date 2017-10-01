using System.Runtime.Serialization;

namespace Xero.Api.Core.Model.Types
{
    [DataContract(Namespace = "")]
    public enum AddressType
    {
        [EnumMember(Value = "UNKNOWN")]
        Unkown = 0,
        [EnumMember(Value = "POBOX")]
        PostOfficeBox,
        [EnumMember(Value = "STREET")]
        Street
    }
}