using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinApp.SqlProvider;

namespace WinApp.Core
{
    public interface IFavouriteDataProvider
    {
        #region [ Add - Update - Remove - InActivate ]
        public void AddFavourite(Favourite Favourite);
        public void RemoveFavourite(Favourite Favourite);
        public void UpdateFavourite(Favourite Favourite);

        #endregion

        #region [ Get Single ]
        public Favourite GetFavouriteById(int id);
        #endregion

        #region [ Get List ]
        public List<Favourite> GetFavouritesByUserId(int id);

        public List<Favourite> GetFavouritesByDocumentId(int id);
        #endregion
    }
}
