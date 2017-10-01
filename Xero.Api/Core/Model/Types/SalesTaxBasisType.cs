using System.Runtime.Serialization;

namespace Xero.Api.Core.Model.Types
{
    [DataContract]
    public enum SalesTaxBasisType
    {
        [EnumMember(Value = "UNKNOWN")]
        Unkown = 0,
        [EnumMember(Value = "NONE")]
        None,
        [EnumMember(Value = "ACCRUAL")]
        Accural,
        [EnumMember(Value = "CASH")]
        Cash,
        [EnumMember(Value = "INVOICE")]
        Invoice,
        [EnumMember(Value = "PAYMENTS")]
        Payments,
        [EnumMember(Value = "FLATRATECASH")]
        FlatRateCash,
        [EnumMember(Value = "FLATRATEACCURAL")]
        FlatRateAccrual,
    }
}