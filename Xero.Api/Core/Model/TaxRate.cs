using System.Collections.Generic;
using System.Runtime.Serialization;
using Xero.Api.Common;
using Xero.Api.Core.Model.Status;
using Xero.Api.Core.Model.Types;

namespace Xero.Api.Core.Model
{
    [DataContract(Namespace = "")]
    public class TaxRate : CoreData
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string TaxType { get; set; }

        [DataMember]
        public List<TaxComponent> TaxComponents { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public ReportTaxType? ReportTaxType { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public TaxRateStatus Status { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public bool? CanApplyToAssets { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public bool? CanApplyToEquity { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public bool? CanApplyToExpenses { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public bool? CanApplyToLiabilities { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public bool? CanApplyToRevenue { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public decimal? DisplayTaxRate { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public decimal? EffectiveRate { get; set; }
    }
}
