using System;
using System.Runtime.Serialization;
using Xero.Api.Common;

namespace Xero.Api.Core.Model
{
    [DataContract(Namespace = "", Name = "Payment")]
    public class BatchPaymentPayment : CoreData
    {
        [DataMember(Name = "Invoice")]
        public Invoice Invoice { get; set; }

        [DataMember(Name = "PaymentID", EmitDefaultValue = false)]
        public Guid? PaymentId { get; set; }

        [DataMember(Name = "BankAccountNumber", EmitDefaultValue = false)]
        public string BankAccountNumber { get; set; }

        [DataMember(Name = "Particulars", EmitDefaultValue = false)]
        public string Particulars { get; set; }

        [DataMember(Name = "Code", EmitDefaultValue = false)]
        public string Code { get; set; }

        [DataMember(Name = "Reference", EmitDefaultValue = false)]
        public string Reference { get; set; }

        [DataMember(Name = "Details", EmitDefaultValue = false)]
        public string Details { get; set; }

        [DataMember(Name = "Narrative", EmitDefaultValue = false)]
        public string Narrative { get; set; }

        [DataMember(Name = "Amount", EmitDefaultValue = false)]
        public decimal? Amount { get; set; }
    }
}