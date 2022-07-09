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
        #region [Add - Update - Remove ]
        public void AddRole(Role Role);
        public void RemoveRole(Role Role);
        public void UpdateRole(Role Role);
        #endregion

        #region [Active - InActivate]
        public void InActivateRole(Role Role);
        public void ActivateRole(Role Role);
        #endregion

        #region [ Get Single]
        public Role GetRoleById(int id);
        #endregion

        #region [ Get List ]
        public List<Role> GetAllRoles();

        public List<Role> GetActiveRoles();
        public List<Role> GetInActiveRoles();
        #endregion
    }
}
