using System;
using System.Collections.Generic;

#nullable disable

namespace WinApp.SqlProvider
{
    public partial class Favourite
    {
        public int FavouriteId { get; set; }
        public int UserId { get; set; }
        public int DocumentId { get; set; }
    }
}
