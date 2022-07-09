using System;
using System.Collections.Generic;

#nullable disable

namespace WinApp.SqlProvider
{
    public partial class Role
    {
        public Role()
        {
            Users = new HashSet<User>();
        }

        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public bool? RoleStatus { get; set; }

        public virtual ICollection<User> Users { get; set; }
        public override string ToString() {
            return this.RoleName.ToString();
        }
    }
}
