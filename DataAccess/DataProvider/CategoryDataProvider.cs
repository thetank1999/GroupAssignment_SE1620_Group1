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
        #region [Add - Update - Remove ]
        public void AddCategory(Category Category) {
            throw new NotImplementedException();
        }
        public void RemoveCategory(Category Category) {
            throw new NotImplementedException();
        }
        public void UpdateCategory(Category Category) {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }
        #endregion

        #region [ Get List ]
        public List<Category> GetAllCategorys() {
            throw new NotImplementedException();
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
