using System.Runtime.Serialization;

namespace Xero.Api.Core.Model.Types
{
    public enum PaymentType
    {
        [EnumMember(Value = "UNKNOWN")]
        Unkown = 0,
        [EnumMember(Value = "ACCPAYPAYMENT")]
        AccountsPayable,
        [EnumMember(Value = "ACCRECPAYMENT")]
        AccountsReceivable,
        [EnumMember(Value = "APCREDITPAYMENT")]
        AccountsPayableCredit,
        [EnumMember(Value = "ARCREDITPAYMENT")]
        AccountsReceivableCredit,
        [EnumMember(Value = "ARPREPAYMENTPAYMENT")]
        AccountsReceivablePrepayment,
        [EnumMember(Value = "APPREPAYMENTPAYMENT")]
        AccountsPayablePrepayment,
        [EnumMember(Value = "AROVERPAYMENTPAYMENT")]
        AccountsReceivableOverpayment,
        [EnumMember(Value = "APOVERPAYMENTPAYMENT")]
        AccountsPayableOverpayment,
    }
}
