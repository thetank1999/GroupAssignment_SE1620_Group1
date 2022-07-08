using System;
using System.Collections.Generic;

#nullable disable

namespace WinApp.SqlProvider { 
    public partial class Role
    {
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public bool? RoleStatus { get; set; }
    }
}
