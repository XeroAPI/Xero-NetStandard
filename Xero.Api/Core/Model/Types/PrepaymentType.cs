using System.Runtime.Serialization;

namespace Xero.Api.Core.Model.Types
{
    [DataContract(Namespace = "")]
    public enum PrepaymentType
    {
        [EnumMember(Value = "UNKNOWN")]
        Unkown = 0,
        [EnumMember(Value = "SPEND-PREPAYMENT")]
        SpendPrepayment,
        [EnumMember(Value = "RECEIVE-PREPAYMENT")]
        ReceivePrepayment
    }
}