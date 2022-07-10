using System;
using System.Collections.Generic;

#nullable disable

namespace WinApp.SqlProvider
{
    public partial class Major
    {
        public Major()
        {
            Documents = new HashSet<Document>();
            Users = new HashSet<User>();
        }

        public int MajorId { get; set; }
        public string MajorName { get; set; }
        public bool? MajorStatus { get; set; }

        public virtual ICollection<Document> Documents { get; set; }
        public virtual ICollection<User> Users { get; set; }
        public override string ToString() {
            return this.MajorName.ToString();
        }
    }
}
