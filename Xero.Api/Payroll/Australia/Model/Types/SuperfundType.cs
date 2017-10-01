using System.Runtime.Serialization;

namespace Xero.Api.Payroll.Australia.Model.Types
{
    [DataContract(Namespace = "")]
    public enum SuperfundType
    {
        [EnumMember(Value = "UNKNOWN")]
        Unkown = 0,
        [EnumMember(Value = "REGULATED")]
        Regulated,
        [EnumMember(Value = "SMSF")]
        SelfManaged
    }
}
