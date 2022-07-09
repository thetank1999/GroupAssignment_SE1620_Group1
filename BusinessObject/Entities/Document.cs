using System;
using System.Collections.Generic;

#nullable disable

namespace WinApp.SqlProvider
{
    public partial class Document
    {
        public Document()
        {
            Favourites = new HashSet<Favourite>();
        }

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

        public virtual User Approver { get; set; }
        public virtual Category Category { get; set; }
        public virtual Major Major { get; set; }
        public virtual User Uploader { get; set; }
        public virtual ICollection<Favourite> Favourites { get; set; }
    }
}
