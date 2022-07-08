using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinApp.SqlProvider;

namespace WinApp.Core
{
    public interface IUserDataProviders
    {
        #region [Add - Update - Remove - InActivate]
        public void AddUser(User user);
        public void RemoveUser(User user);
        public void UpdateUser(User user);
        
        public void InActivateUser(User user);
        #endregion

        #region [ Get Single]
        public User GetUser (int id);
        public User GetUserByEmail(string email);
        #endregion

        #region [ Get List ]
        public List<User> GetAllUsers();

        public List<User> GetActiveUsers();
        #endregion
    }
}
