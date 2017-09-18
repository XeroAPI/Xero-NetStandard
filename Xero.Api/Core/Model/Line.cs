using System;
using System.Runtime.Serialization;
using Xero.Api.Common;
using Xero.Api.Core.Model.Types;

namespace Xero.Api.Core.Model
{
    [DataContract(Name = "JournalLine", Namespace = "")]
    public class Line : CoreData, IHasId
    {
        [DataMember(Name = "JournalLineID", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        [DataMember(Name = "AccountID", EmitDefaultValue = false)]
        public Guid AccountId { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string AccountCode { get; set; }

        [DataMember]
        public AccountType AccountType { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string AccountName { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public decimal NetAmount { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public decimal GrossAmount { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public decimal TaxAmount { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string TaxType { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string TaxName { get; set; }
        
        //There is an inconsistency with TrackingCatgories on JournalLines between Journals and ManualJournals.
        //Use TrackingCategories with Journals
        [DataMember(EmitDefaultValue = false)]
        public ItemTracking TrackingCategories { get; set; }

        //Use Tracking with ManualJournals
        [DataMember(EmitDefaultValue = false)]
        public ItemTracking Tracking { get; set; }

        [DataMember(Name = "LineAmount", EmitDefaultValue = false)]
        public decimal Amount { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string Description { get; set; }

    }
}