using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinApp.Core;
using WinApp.SqlProvider;

namespace WinApp.DataProviders {
    public class CategoryDataProvider : ICategoryDataProvider
    {
        #region [ Fields ]
        private readonly GroupAssignmentContext _dbContext;
        #endregion

        #region [ CTor ]
        public CategoryDataProvider(GroupAssignmentContext dbContext) {
            _dbContext = dbContext;
        }
        #endregion

        #region [Add - Update - Remove ]
        public void AddCategory(Category Category) {
            try {
                var dbEntity = _dbContext.Categories.FirstOrDefault(x => x.CategoryId == Category.CategoryId);
                if (dbEntity == null) {
                    _dbContext.Categories.Add(Category);
                    _dbContext.SaveChanges();
                } else {
                    throw new Exception();
                }
            } catch (Exception ex) {

                throw new Exception(ex.ToString());
            }
        }
        public void RemoveCategory(Category Category) {
            try {
                var dbEntity = _dbContext.Categories.FirstOrDefault(x => x.CategoryId == Category.CategoryId);
                if (dbEntity != null) {
                    _dbContext.Categories.Remove(Category);
                    _dbContext.SaveChanges();
                } else {
                    throw new Exception();
                }
            } catch (Exception ex) {

                throw new Exception(ex.ToString());
            }
        }
        public void UpdateCategory(Category Category) {
            try {
                var dbEntity = _dbContext.Categories.FirstOrDefault(x => x.CategoryId == Category.CategoryId);
                if (dbEntity != null) {
                    _dbContext.Categories.Update(Category);
                    _dbContext.SaveChanges();
                } else {
                    throw new Exception();
                }
            } catch (Exception ex) {

                throw new Exception(ex.ToString());
            }
        }
        #endregion

        #region [ Active - InActivate ]
        public void InActivateCategory(Category Category) {
            throw new NotImplementedException();
        }
        public void ActivateCategory(Category Category) {
            throw new NotImplementedException();
        }
        #endregion

        #region [ Get Single]
        public Category GetCategoryById(int id) {
            Category category = null;
            try {
                category = _dbContext.Categories.FirstOrDefault(x => x.CategoryId == id);
            } catch (Exception ex) {

                throw new Exception(ex.ToString());
            }
            return category;
        }
        #endregion

        #region [ Get List ]
        public List<Category> GetAllCategorys() {
            var result = new List<Category>();
            try {
                result = _dbContext.Categories.ToList();
            } catch (Exception ex) {

                throw new Exception(ex.ToString());
            }
            return result;
        }

        public List<Category> GetActiveCategorys() {
            throw new NotImplementedException();
        }
        public List<Category> GetInActiveCategorys() {
            throw new NotImplementedException();
        }
        #endregion
    }
}
