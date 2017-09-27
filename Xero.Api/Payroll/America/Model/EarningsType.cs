using System;
using System.Runtime.Serialization;
using Xero.Api.Common;
using Xero.Api.Payroll.America.Model.Types;

namespace Xero.Api.Payroll.America.Model
{
    [DataContract(Namespace = "")]
    public class EarningsType : HasUpdatedDate
    {
        [DataMember(Name = "EarningsRateID")]
        public Guid Id { get; set; }

        [DataMember(Name = "EarningsType")]
        public string Name { get; set; }

        [DataMember]
        public string ExpenseAccountCode { get; set; }

        [DataMember]
        public EarningsCategoryType EarningsCategory { get; set; }

        [DataMember]
        public RateType RateType { get; set; }

        [DataMember]
        public UnitType TypeOfUnits { get; set; }

        [DataMember]
        public decimal? Multiple { get; set; }

        [DataMember]
        public bool DoNotAccureTimeOff { get; set; }

        [DataMember]
        public bool IsSupplemental { get; set; }

        [DataMember]
        public decimal? Amount { get; set; }
    }
}