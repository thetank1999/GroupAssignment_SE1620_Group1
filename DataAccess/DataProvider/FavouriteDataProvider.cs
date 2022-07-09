using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinApp.Core;
using WinApp.SqlProvider;

namespace WinApp.DataProviders
{
    public class FavouriteDataProvider : IFavouriteDataProvider
    {
        public void AddFavourite(Favourite Favourite) {
            throw new NotImplementedException();
        }

        public Favourite GetFavouriteById(int id) {
            throw new NotImplementedException();
        }

        public List<Favourite> GetFavouritesByDocumentId(int id) {
            throw new NotImplementedException();
        }

        public List<Favourite> GetFavouritesByUserId(int id) {
            throw new NotImplementedException();
        }

        public void RemoveFavourite(Favourite Favourite) {
            throw new NotImplementedException();
        }

        public void UpdateFavourite(Favourite Favourite) {
            throw new NotImplementedException();
        }
    }
}
