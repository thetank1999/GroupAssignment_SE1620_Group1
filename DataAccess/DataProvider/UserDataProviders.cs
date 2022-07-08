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
    public class UserDataProviders : IUserDataProviders
    {
        #region [ Fields ]
        //private readonly IDbContextFactory<GroupAssignmentContext> _dbContext;  IDbContextFactory<GroupAssignmentContext> dbContext
        #endregion

        #region [ CTor ]
        public UserDataProviders() {
            
        }
        #endregion
        #region [Add - Update - Remove - InActivate]
        public void AddUser(User user) {
            throw new NotImplementedException();
        }
        public void RemoveUser(User user) {
            throw new NotImplementedException();
        }
        public void UpdateUser(User user) {
            throw new NotImplementedException();
        }

        public void InActivateUser(User user) {
            throw new NotImplementedException();
        }
        #endregion

        #region [ Get Single]
        public User GetUser(int id) {
            User user = null;
            try {
                using var context = new GroupAssignmentContext();
                user = context.Users.FirstOrDefault(x => x.UserId == id);
            } catch (Exception ex) {

                throw new Exception(ex.ToString());
            }
            return user;
        }
        public User GetUserByEmail(string email) {
            User user = null;
            try {
                using var context = new GroupAssignmentContext();
                user = context.Users.FirstOrDefault(x => x.UserEmail.Equals(email.ToString().Trim()));
            } catch (Exception ex) {

                throw new Exception( ex.ToString() );
            } return user;
        }
        #endregion

        #region [ Get List ]
        public List<User> GetAllUsers() {
            throw new NotImplementedException();
        }

        public List<User> GetActiveUsers() {
            throw new NotImplementedException();
        }
        #endregion
    }
}
