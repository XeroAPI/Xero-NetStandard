using System;
using System.Runtime.Serialization;
using Xero.Api.Common;
using Xero.Api.Payroll.America.Model.Types;

namespace Xero.Api.Payroll.America.Model
{
    [DataContract(Namespace = "")]
    public class BenefitType : HasUpdatedDate
    {
        [DataMember(Name = "BenefitTypeID")]
        public Guid Id { get; set; }
        
        [DataMember(Name = "BenefitType")]
        public string Name { get; set; }
        
        [DataMember]
        public BenefitCategoryType BenefitCategoryType { get; set; }

        [DataMember]
        public string LiabilityAccountCode { get; set; }

        [DataMember]
        public string ExpenseAccountCode { get; set; }

        [DataMember]
        public decimal? StandardAmount { get; set; }

        [DataMember]
        public decimal? CompanyMax { get; set; }

        [DataMember]
        public decimal? Percentage { get; set; }

        [DataMember]
        public bool ShowBalanceOnPaystub { get; set; }
    }
}