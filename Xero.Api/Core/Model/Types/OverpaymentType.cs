using System.Runtime.Serialization;

namespace Xero.Api.Core.Model.Types
{
    [DataContract(Namespace = "")]
    public enum OverpaymentType
    {
        [EnumMember(Value = "UNKNOWN")]
        Unkown = 0,
        [EnumMember(Value = "SPEND-OVERPAYMENT")]
        SpendOverpayment,
        [EnumMember(Value = "RECEIVE-OVERPAYMENT")]
        ReceiveOverpayment
    }
}