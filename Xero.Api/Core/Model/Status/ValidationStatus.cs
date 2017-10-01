using System.Runtime.Serialization;

namespace Xero.Api.Core.Model.Status
{
    [DataContract(Namespace = "")]
    public enum ValidationStatus
    {
        [EnumMember(Value = "UNKNOWN")]
        Unkown = 0,
        [EnumMember(Value = "OK")]
        Ok,
        [EnumMember(Value = "WARNING")]
        Warning,
        [EnumMember(Value = "ERROR")]
        Error
    }
}