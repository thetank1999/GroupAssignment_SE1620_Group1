using System;
using System.Collections.Generic;

#nullable disable

namespace WinApp.SqlProvider
{
    public partial class Document
    {
        public int DocumentId { get; set; }
        public int MajorId { get; set; }
        public int CategoryId { get; set; }
        public int UploaderId { get; set; }
        public int ApproverId { get; set; }
        public string DocumentType { get; set; }
        public byte[] DocumentData { get; set; }
        public string DocumentUrl { get; set; }
        public bool? DocumentStatus { get; set; }
        public bool IsApproved { get; set; }
    }
}
