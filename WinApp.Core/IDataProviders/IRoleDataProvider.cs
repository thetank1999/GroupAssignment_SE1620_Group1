using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinApp.SqlProvider;

namespace WinApp.Core
{
    public interface IRoleDataProvider
    {
        #region [Add - Update - Remove - InActivate]
        public void AddRole(Role Role);
        public void RemoveRole(Role Role);
        public void UpdateRole(Role Role);

        public void InActivateRole(Role Role);
        #endregion

        #region [ Get Single]
        public Role GetRoleById(int id);
        #endregion

        #region [ Get List ]
        public List<Role> GetAllRoles();

        public List<Role> GetActiveRoles();
        #endregion
    }
}
