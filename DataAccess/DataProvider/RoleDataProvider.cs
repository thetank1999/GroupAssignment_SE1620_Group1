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
        private readonly GroupAssignmentContext _dbContext;
        #endregion

        #region [ CTor ]
        public RoleDataProvider(GroupAssignmentContext dbContext) {
            _dbContext = dbContext;
        }
        #endregion
        #region [Add - Update - Remove ]
        public void AddRole(Role Role) {
            throw new NotImplementedException();
        }
        public void RemoveRole(Role Role) {
            throw new NotImplementedException();
        }
        public void UpdateRole(Role Role) {
            throw new NotImplementedException();
        }
        #endregion

        #region [Active - InActivate]
        public void InActivateRole(Role Role) {
            throw new NotImplementedException();
        }
        public void ActivateRole(Role Role) {
            throw new NotImplementedException();
        }
        #endregion

        #region [ Get Single]
        public Role GetRoleById(int id) {
            Role role = null;
            try {
                role = _dbContext.Roles.FirstOrDefault(x => x.RoleId == id);
            } catch (Exception ex) {

                throw new Exception(ex.ToString());
            }
            return role;
        }
        #endregion

        #region [ Get List ]
        public List<Role> GetAllRoles() {
            var result = new List<Role>();
            try {
                result = _dbContext.Roles.ToList();
            } catch (Exception ex) {

                throw new Exception(ex.ToString());
            }
            return result;
        }

        public List<Role> GetActiveRoles() {
            throw new NotImplementedException();
        }
        public List<Role> GetInActiveRoles() {
            throw new NotImplementedException();
        }
        #endregion
    }
}
