using System.Runtime.Serialization;

namespace Xero.Api.Core.Model.Types
{
    [DataContract(Namespace = "")]
    public enum BatchPaymentType
    {
        [EnumMember(Value = "PAYBATCH")]
        PayBatch,
        [EnumMember(Value = "RECBATCH")]
        RecBatch
    }
}