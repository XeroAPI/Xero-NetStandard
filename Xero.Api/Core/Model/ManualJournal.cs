using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Xero.Api.Common;
using Xero.Api.Core.Model.Status;
using Xero.Api.Core.Model.Types;

namespace Xero.Api.Core.Model
{
    [DataContract(Namespace = "")]
    public class ManualJournal : HasUpdatedDate, IHasId, IHasAttachment
    {
        [DataMember(Name = "ManualJournalID", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public DateTime? Date { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public ManualJournalStatus? Status { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public LineAmountType? LineAmountTypes { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string Url { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public bool? ShowOnCashBasisReports { get; set; }

        [DataMember]
        public string Narration { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public bool? HasAttachments { get; set; }

        [DataMember(Name="JournalLines")]
        public List<Line> Lines { get; set; }
    }
}
