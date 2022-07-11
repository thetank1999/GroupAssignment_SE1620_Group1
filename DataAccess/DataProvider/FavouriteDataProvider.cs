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
        #region [ Fields ]
        private readonly GroupAssignmentContext _dbContext;
        #endregion

        #region [ CTor ]
        public FavouriteDataProvider(GroupAssignmentContext dbContext) {
            _dbContext = dbContext;
        }
        #endregion

        #region [Add - Update - Remove ]
        public void RemoveFavourite(Favourite Favourite) {
            try {
                var dbEntity = this.GetFavouriteById(Favourite.FavouriteId);
                if (dbEntity != null) {
                    _dbContext.Favourites.Remove(Favourite);
                    _dbContext.SaveChanges();
                } else {
                    throw new Exception();
                }
            } catch (Exception ex) {

                throw new Exception(ex.ToString());
            }
        }
        public void UpdateFavourite(Favourite Favourite) {
            try {
                var dbEntity = this.GetFavouriteById(Favourite.FavouriteId);
                if (dbEntity != null) {
                    _dbContext.Favourites.Update(Favourite);
                    _dbContext.SaveChanges();
                } else {
                    throw new Exception();
                }
            } catch (Exception ex) {

                throw new Exception(ex.ToString());
            }
        }
        public void AddFavourite(Favourite Favourite) {
            try {
                var dbEntity = _dbContext.Favourites.FirstOrDefault(x => x.FavouriteId == Favourite.FavouriteId);
                if (dbEntity == null) {
                    _dbContext.Favourites.Add(Favourite);
                    _dbContext.SaveChanges();
                } else {
                    throw new Exception();
                }
            } catch (Exception ex) {

                throw new Exception(ex.ToString());
            }
        }
        #endregion

        #region [ Get Single]
        public Favourite GetFavouriteById(int id) {
            Favourite favourite = null;
            try {
                favourite = _dbContext.Favourites.FirstOrDefault(x => x.FavouriteId == id);
            } catch (Exception ex) {

                throw new Exception(ex.ToString());
            }
            return favourite;
        }
        #endregion

        #region [ Get List ]
        public List<Favourite> GetFavouritesByDocumentId(int id) {
            var result = new List<Favourite>();
            try {
                result = _dbContext.Favourites.Where(x => x.DocumentId == id).ToList();
            } catch (Exception ex) {

                throw new Exception(ex.ToString());
            }
            return result;
        }

        public List<Favourite> GetFavouritesByUserId(int id) {
            var result = new List<Favourite>();
            try {
                result = _dbContext.Favourites.Where(x => x.UserId == id ).ToList();
            } catch (Exception ex) {

                throw new Exception(ex.ToString());
            }
            return result;
        }
        #endregion

    }
}
