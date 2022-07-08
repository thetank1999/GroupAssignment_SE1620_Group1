using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinApp.SqlProvider;

namespace WinApp.Core
{
    public interface ICategoryDataProvider
    {
        #region [Add - Update - Remove - InActivate]
        public void AddCategory(Category Category);
        public void RemoveCategory(Category Category);
        public void UpdateCategory(Category Category);

        public void InActivateCategory(Category Category);
        #endregion

        #region [ Get Single]
        public Category GetCategoryById(int id);
        #endregion

        #region [ Get List ]
        public List<Category> GetAllCategorys();

        public List<Category> GetActiveCategorys();
        #endregion
    }
}
