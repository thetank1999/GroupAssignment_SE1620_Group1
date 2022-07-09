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
        #region [Add - Update - Remove ]
        public void AddCategory(Category Category);
        public void RemoveCategory(Category Category);
        public void UpdateCategory(Category Category);
        #endregion

        #region [ Active - InActivate ]
        public void InActivateCategory(Category Category);
        public void ActivateCategory(Category Category);
        #endregion

        #region [ Get Single]
        public Category GetCategoryById(int id);
        #endregion

        #region [ Get List ]
        public List<Category> GetAllCategorys();

        public List<Category> GetActiveCategorys();
        public List<Category> GetInActiveCategorys();
        #endregion
    }
}
