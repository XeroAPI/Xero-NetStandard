using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Xero.Api.Common;
using Xero.Api.Core.Model.Status;
using Xero.Api.Core.Model.Types;

namespace Xero.Api.Core.Model
{
    [DataContract(Namespace = "")]
    public class CreditNote : HasUpdatedDate, IHasId, IHasAttachment
    {
        [DataMember(Name = "CreditNoteID", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        [DataMember(Name = "CreditNoteNumber", EmitDefaultValue = false)]
        public string Number { get; set; }

        [DataMember]
        public CreditNoteType Type { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string Reference { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public bool? SentToContact { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public decimal? AppliedAmount { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public decimal? RemainingCredit { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public decimal? CurrencyRate { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public Contact Contact { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public DateTime? Date { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public DateTime? DueDate { get; set; }

        [DataMember(Name = "BrandingThemeID", EmitDefaultValue = false)]
        public Guid BrandingThemeId { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public InvoiceStatus Status { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public LineAmountType LineAmountTypes { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public decimal? SubTotal { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public decimal? TotalTax { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public decimal? Total { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string CurrencyCode { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public bool? HasAttachments { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public DateTime? FullyPaidOnDate { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public List<LineItem> LineItems { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public List<CreditNoteAllocation> Allocations { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public List<Payment> Payments { get; set; }
    }
}