using System;
using System.Runtime.Serialization;

namespace Xero.Api.Core.Model
{
    [DataContract(Namespace = "")]
    public class File
    {
        [DataMember(EmitDefaultValue = false)]
        public string Name { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string FileName { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public Guid Id { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public Guid FolderId { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string Mimetype { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public long Size { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public DateTime? CreatedDateUtc { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public DateTime? UpdatedDateUtc { get; set; }

        public FilesUser User { get; set; }

        public byte[] Content { get; set; }
    }
}