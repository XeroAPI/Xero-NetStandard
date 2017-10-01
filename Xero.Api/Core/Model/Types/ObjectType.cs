using System.Runtime.Serialization;

namespace Xero.Api.Core.Model.Types
{
    public enum ObjectType 
    {
        [EnumMember(Value = "ACCOUNT")]
        Account,
        [EnumMember(Value = "ACCPAY")]
        PurchasesInvoice,
        [EnumMember(Value = "ACCPAYCREDIT")]
        PurchasesCreditNote,
        [EnumMember(Value = "ACCPAYPAYMENT")]
        PaymentOnPurchasesInvoice,
        [EnumMember(Value = "ACCREC")]
        SalesInvoice,
        [EnumMember(Value = "ACCRECCREDIT")]
        SalesCreditNote,
        [EnumMember(Value = "ACCRECPAYMENT")]
        PaymentOnSalesInvoice,
        [EnumMember(Value = "ADJUSTMENT")]
        ReconciliationAdjustment,
        [EnumMember(Value = "APCREDITPAYMENT")]
        PaymentOnPurchasesCreditNote,
        [EnumMember(Value = "APOVERPAYMENT")]
        PurchasesOverpayment,
        [EnumMember(Value = "APOVERPAYMENTPAYMENT")]
        PurchasesOverpaymentPayment,
        [EnumMember(Value = "APOVERPAYMENTSOURCEPAYMENT")]
        BankPartOfPurchasesOverpayment,
        [EnumMember(Value = "APPREPAYMENT")]
        PurchasesPrepayment,
        [EnumMember(Value = "APPREPAYMENTPAYMENT")]
        PurchasesPrepaymentPayment,
        [EnumMember(Value = "APPREPAYMENTSOURCEPAYMENT")]
        BankPartOfPurchasesPrepayment,
        [EnumMember(Value = "ARCREDITPAYMENT")]
        PaymentOnSalesCreditNote,
        [EnumMember(Value = "AROVERPAYMENT")]
        SalesOverpayment,
        [EnumMember(Value = "AROVERPAYMENTPAYMENT")]
        SalesOverpaymentPayment,
        [EnumMember(Value = "AROVERPAYMENTSOURCEPAYMENT")]
        BankPartOfSalesOverpayment,
        [EnumMember(Value = "ARPREPAYMENT")]
        SalesPrepayment,
        [EnumMember(Value = "ARPREPAYMENTPAYMENT")]
        SalesPrepaymentPayment,
        [EnumMember(Value = "ARPREPAYMENTSOURCEPAYMENT")]
        BankPartOfSalesPrepayment,
        [EnumMember(Value = "CASHPAID")]
        SpendMoneyTransaction,
        [EnumMember(Value = "CASHREC")]
        ReceiveMoneyTransaction,
        [EnumMember(Value = "CONTACT")]
        Contact,
        [EnumMember(Value = "EXPPAYMENT")]
        ExpenseClaimPayment,
        [EnumMember(Value = "FIXEDASSET")]
        FixedAsset,
        [EnumMember(Value = "MANJOURNAL")]
        ManualJournal,
        [EnumMember(Value = "PAYRUN")]
        Payrun,
        [EnumMember(Value = "PRICELISTITEM")]
        Item,
        [EnumMember(Value = "PURCHASEORDER")]
        PurchaseOrder,
        [EnumMember(Value = "RECEIPT")]
        ExpenseReceipt,
        [EnumMember(Value = "TRANSFER")]
        BankTransfer
    }
}
