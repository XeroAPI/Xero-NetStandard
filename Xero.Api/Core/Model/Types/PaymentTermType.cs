using System.Runtime.Serialization;

namespace Xero.Api.Core.Model.Types
{
    [DataContract(Namespace = "")]
    public enum PaymentTermType
    {
        [EnumMember(Value = "UNKNOWN")]
        Unkown = 0,
        [EnumMember(Value = "OFFOLLOWINGMONTH")]
        FollowingMonth,
        [EnumMember(Value = "DAYSAFTERBILLDATE")]
        AfterBillDate,
        [EnumMember(Value = "OFCURRENTMONTH")]
        CurrentMonth,
        [EnumMember(Value = "DAYSAFTERBILLMONTH")]
        DaysAfterBillMonth,
        [EnumMember(Value = "DAYSAFTERINVOICEMONTH")]
        AfterInvoiceMonth
    }
}