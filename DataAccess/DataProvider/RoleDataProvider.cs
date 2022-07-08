using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinApp.Core;
using WinApp.SqlProvider;

namespace WinApp.DataProviders
{
    public class RoleDataProvider : IRoleDataProvider
    {
        #region [ Fields ]
        private readonly IDbContextFactory<GroupAssignmentContext> _dbContext;
        #endregion

        #region [ CTor ]
        public RoleDataProvider(IDbContextFactory<GroupAssignmentContext> dbContext) {
            this._dbContext = dbContext;
        }
        #endregion
        #region [Add - Update - Remove - InActivate]
        public void AddRole(Role Role) {
            throw new NotImplementedException();
        }
        public void RemoveRole(Role Role) {
            throw new NotImplementedException();
        }
        public void UpdateRole(Role Role) {
            throw new NotImplementedException();
        }

        public void InActivateRole(Role Role) {
            throw new NotImplementedException();
        }
        #endregion

        #region [ Get Single]
        public Role GetRoleById(int id) {
            throw new NotImplementedException();
        }
        #endregion

        #region [ Get List ]
        public List<Role> GetAllRoles() {
            throw new NotImplementedException();
        }

        public List<Role> GetActiveRoles() {
            throw new NotImplementedException();
        }
        #endregion
    }
}
