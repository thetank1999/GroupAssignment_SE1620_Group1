﻿using Microsoft.EntityFrameworkCore;
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
        public List<Role> GetInActiveRoles() {
            throw new NotImplementedException();
        }
        #endregion
    }
}
