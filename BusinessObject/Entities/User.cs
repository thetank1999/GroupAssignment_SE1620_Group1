using System;
using System.Collections.Generic;

#nullable disable

namespace WinApp.SqlProvider { 
    public partial class User
    {
        public int UserId { get; set; }
        public int UserRoleId { get; set; }
        public string UserEmail { get; set; }
        public string UserFullname { get; set; }
        public string UserPassword { get; set; }
        public bool? UserStatus { get; set; }
    }
}
