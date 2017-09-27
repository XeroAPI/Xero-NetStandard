using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Xero.Api.Common;
using Xero.Api.Core.Model.Status;
using Xero.Api.Core.Model.Types;

namespace Xero.Api.Core.Model
{
    [DataContract(Namespace = "")]
    public class BankTransaction : HasUpdatedDate, IHasId, IHasAttachment
    {
        [DataMember(Name = "BankTransactionID", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        [DataMember]
        public Contact Contact { get; set; }

        [DataMember]
        public Account BankAccount { get; set; }

        [DataMember]
        public BankTransactionType Type { get; set; }

        [DataMember]
        public BankTransactionStatus Status { get; set; }
        
        [DataMember]
        public LineAmountType LineAmountTypes { get; set; }
        
        [DataMember(EmitDefaultValue = false)]
        public bool? IsReconciled { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public DateTime? Date { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string Reference { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public decimal? CurrencyRate { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string CurrencyCode { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string Url { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public decimal? SubTotal { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public decimal? TotalTax { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public decimal? Total { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public bool? HasAttachments { get; set; }

        [DataMember]
        public List<LineItem> LineItems { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public Guid? PrepaymentID { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public Guid? OverpaymentID { get; set; }
    }
}
