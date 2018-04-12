using System.Collections.Generic;
using Xero.Api.Common;
using Xero.Api.Core.Model;

namespace Xero.Api.Core.Response
{
    public class HistoryRecordsResponse : XeroResponse<HistoryRecord>
    {
        public List<HistoryRecord> HistoryRecords { get; set; }

        public override IList<HistoryRecord> Values
        {
            get { return HistoryRecords; }
        }
    }
}