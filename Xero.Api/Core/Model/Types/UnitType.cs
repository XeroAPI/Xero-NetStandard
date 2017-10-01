using System.Runtime.Serialization;

namespace Xero.Api.Core.Model.Types
{
    [DataContract(Namespace = "")]
    public enum UnitType
    {
        [EnumMember(Value = "UNKNOWN")]
        Unkown = 0,
        [EnumMember(Value = "WEEKLY")]
        Weekly,
        [EnumMember(Value = "MONTHLY")]
        Monthly
    }
}