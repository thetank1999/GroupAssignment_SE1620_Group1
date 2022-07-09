using System;
using System.Collections.Generic;

#nullable disable

namespace WinApp.SqlProvider
{
    public partial class Category
    {
        public Category()
        {
            Documents = new HashSet<Document>();
        }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public bool? CategoryStatus { get; set; }

        public virtual ICollection<Document> Documents { get; set; }
        public override string ToString() {
            return this.CategoryName.ToString();
        }
    }
}
