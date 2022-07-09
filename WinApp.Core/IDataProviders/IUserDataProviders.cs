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
        #region [Add - Update - Remove ]
        public void AddUser(User user);
        public void RemoveUser(User user);
        public void UpdateUser(User user);
        #endregion
        #region [Active - InActivate]
        public void ActivateUser(User user);
        public void InActivateUser(User user);
        #endregion

        #region [ Get Single]
        public User GetUser (int id);
        public User GetUserByEmail(string email);

        public User GetUserLogin (string email, string password);
        #endregion

        #region [ Get List ]
        public List<User> GetAllUsers();
        public List<User> GetActiveUsers();
        public List<User> GetInActiveUsers();
        #endregion
    }
}
