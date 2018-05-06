using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Xero.Api.Common;
using Xero.Api.Core.Model.Status;
using Xero.Api.Core.Model.Types;

namespace Xero.Api.Core.Model
{
    [DataContract(Namespace = "")]
    public class Overpayment : HasUpdatedDate, IHasId, IHasAttachment
    {
        [DataMember(Name = "OverpaymentID")]
        public Guid Id { get; set; }

        [DataMember]
        public Contact Contact { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public DateTime? Date { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public OverpaymentStatus Status { get; set; }

        [DataMember]
        public LineAmountType LineAmountTypes { get; set; }

        [DataMember]
        public List<LineItem> LineItems { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public decimal? SubTotal { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public decimal? TotalTax { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public decimal? Total { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string CurrencyCode { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public decimal? CurrencyRate { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public OverpaymentType Type { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public decimal? AppliedAmount { get; set; }

        [DataMember]
        public Decimal RemainingCredit { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public bool? HasAttachments { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public List<OverpaymentAllocation> Allocations { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public List<Payment> Payments { get; set; }
    }
}
