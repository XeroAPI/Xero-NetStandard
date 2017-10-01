using System.Runtime.Serialization;

namespace Xero.Api.Core.Model.Types
{
    [DataContract(Namespace = "")]
    public enum PhoneType
    {
        [EnumMember(Value = "UNKNOWN")]
        Unkown = 0,
        [EnumMember(Value="DEFAULT")]
        Default,
        [EnumMember(Value = "DDI")]
        DirectDial,
        [EnumMember(Value = "MOBILE")]
        Mobile,
        [EnumMember(Value = "FAX")]
        Fax        
    }
}