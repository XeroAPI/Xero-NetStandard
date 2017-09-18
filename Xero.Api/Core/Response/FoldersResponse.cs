using System.Collections.Generic;
using Xero.Api.Common;
using Xero.Api.Core.Model;

namespace Xero.Api.Core.Response
{
    public class FoldersResponse : XeroResponse<Model.Folder>
    {
        public string Name { get; set; }

        public bool IsInbox { get; set; }

        public int FileCount { get; set; }

        public List<Folder> Folders { get; set; }

        public override IList<Folder> Values
        {
            get { return Folders; }
        }
    }
}