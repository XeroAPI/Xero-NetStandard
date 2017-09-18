using System.Runtime.Serialization;

namespace Xero.Api.Core.Model.Types
{
    [DataContract(Namespace = "")]
    public enum SourceType
    {
        [EnumMember(Value = "ACCREC")]
        AccountsReceivableInvoice,
        [EnumMember(Value = "ACCPAY")]
        AccountsPayableInvoice,
        [EnumMember(Value = "ACCRECCREDIT")]
        AccountsReceivableCreditNote,
        [EnumMember(Value = "ACCPAYCREDIT")]
        AccountsPayableCreditNote,
        [EnumMember(Value = "ACCRECPAYMENT")]
        PaymentOnAnAccountsReceivableInvoice,
        [EnumMember(Value = "ACCPAYPAYMENT")]
        PaymentOnAnAccountsPayableInvoice,
        [EnumMember(Value = "ARCREDITPAYMENT")]
        AccountsReceivableCreditNotePayment,
        [EnumMember(Value = "APCREDITPAYMENT")]
        AccountsPayableCreditNotePayment,
        [EnumMember(Value = "CASHREC")]
        ReceiveMoneyBankTransaction,
        [EnumMember(Value = "CASHPAID")]
        SpendMoneyBankTransaction,
        [EnumMember(Value = "TRANSFER")]
        BankTransfer,
        [EnumMember(Value = "ARPREPAYMENT")]
        AccountsReceivablePrepayment,
        [EnumMember(Value = "APPREPAYMENT")]
        AccountsPayablePrepayment,
        [EnumMember(Value = "AROVERPAYMENT")]
        AccountsReceivableOverpayment,
        [EnumMember(Value = "APOVERPAYMENT")]
        AccountsPayableOverpayment,
        [EnumMember(Value = "EXPCLAIM")]
        ExpenseClaim,
        [EnumMember(Value = "EXPPAYMENT")]
        ExpenseClaimPayment,
        [EnumMember(Value = "MANJOURNAL")]
        ManualJournal,
        [EnumMember(Value = "PAYSLIP")]
        Payslip,
        [EnumMember(Value = "WAGEPAYABLE")]
        PayrollPayable,
        [EnumMember(Value = "INTEGRATEDPAYROLLPE")]
        PayrollExpense,

    }
}
