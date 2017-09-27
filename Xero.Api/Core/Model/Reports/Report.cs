using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Xero.Api.Core.Model.Types;

namespace Xero.Api.Core.Model.Reports
{
    [DataContract(Namespace = "")]
    public class Report
    {
        [DataMember]
        public string ReportID { get; set; }

        [DataMember]
        public string ReportName { get; set; }

        [DataMember]
        public NamedReportType ReportType { get; set; }

        [DataMember]
        public List<string> ReportTitles { get; set; }

        [DataMember]
        public string ReportDate { get; set; }

        // ReSharper disable InconsistentNaming
        [DataMember(EmitDefaultValue = false)]
        public DateTime? UpdatedDateUTC { get; set; }
        // ReSharper restore InconsistentNaming

        [DataMember]
        public List<ReportAttribute> Attributes { get; set; }

        [DataMember]
        public List<ReportField> Fields { get; set; }

        [DataMember]
        public List<ReportRow> Rows { get; set; }
    }
}
