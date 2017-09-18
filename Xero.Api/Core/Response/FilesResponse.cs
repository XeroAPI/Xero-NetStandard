using System;
using System.Collections.Generic;
using System.Linq;
using Xero.Api.Common;

namespace Xero.Api.Core.Response
{
    public class FilesResponse : XeroResponse<Model.File>
    {
        public List<Model.File> Items { get; set; }

        public override IList<Model.File> Values
        {
            get { return Items; }
        }
    }


    public class FilePageResponse : XeroResponse<Model.FilePage>
    {
        public string Name { get; set; }

        public bool IsInbox { get; set; }
        
        public IList<Model.FilePage>  Files { get; set; }

        public override IList<Model.FilePage> Values
        {
            get { return Files; }
        }


        public Model.File this [Guid guid]
        {
            get
            {
                return Files.Single().Items.SingleOrDefault(i => i.Id == guid);
                
            }
        }

    }
}


