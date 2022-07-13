using System;
using System.Collections.Generic;
using System.Linq;
using WinApp.Core;
using WinApp.SqlProvider;

namespace WinApp.DataProviders
{
    public class UserDataProviders : IUserDataProviders
    {
        #region [ Fields ]
        private readonly GroupAssignmentContext _dbContext;  
        #endregion

        #region [ CTor ]
        public UserDataProviders(GroupAssignmentContext dbContext) {
            _dbContext = dbContext;
        }
        #endregion
        #region [Add - Update - Remove - InActivate]
        public void AddUser(User user) {
            try {
                var dbEntity = _dbContext.Users.FirstOrDefault(x => x.UserId == user.UserId);
                if (dbEntity == null) {
                    _dbContext.Users.Add(user);
                    _dbContext.SaveChanges();
                } else {
                    throw new Exception();
                }
            } catch (Exception ex) {

                throw new Exception(ex.ToString());
            }
        }
        public void RemoveUser(User user) {
            try {
                var dbEntity = _dbContext.Users.FirstOrDefault(x => x.UserId == user.UserId);
                if (dbEntity != null) {
                    _dbContext.Users.Remove(user);
                    _dbContext.SaveChanges();
                } else {
                    throw new Exception();
                }
            } catch (Exception ex) {

                throw new Exception(ex.ToString());
            }
        }
        public void UpdateUser(User user) {
            try {
                var dbEntity = _dbContext.Users.FirstOrDefault(x => x.UserId == user.UserId);
                if (dbEntity != null) {
                    _dbContext.Users.Update(user);
                    _dbContext.SaveChanges();
                } else {
                    throw new Exception();
                }
            } catch (Exception ex) {

                throw new Exception(ex.ToString());
            }
        }

        public void InActivateUser(User user) {
            user.UserStatus = false;
            this.UpdateUser(user);
        }
        public void ActivateUser(User user) {
            user.UserStatus = true;
            this.UpdateUser(user);
        }

        #endregion

        #region [ Get Single]
        public User GetUserLogin(string email, string password) {
            User user = null;
            try {
                user = _dbContext.Users.FirstOrDefault(x => x.UserEmail.Equals(email) && x.UserPassword.Equals(password) && x.UserStatus == true);
            } catch (Exception ex) {

                throw new Exception(ex.ToString());
            }
            return user;
        }
        public User GetUser(int id) {
            User user = null;
            try { 
                user = _dbContext.Users.FirstOrDefault(x => x.UserId == id);
            } catch (Exception ex) {

                throw new Exception(ex.ToString());
            }
            return user;
        }
        public User GetUserByEmail(string email) {
            User user = null;
            try {
                user = _dbContext.Users.FirstOrDefault(x => x.UserEmail.Equals(email.ToString().Trim()));
            } catch (Exception ex) {

                throw new Exception( ex.ToString() );
            } return user;
        }
        #endregion

        #region [ Get List ]
        public List<User> GetAllUsers() {
            var result = new List<User>();
            try {
                result = _dbContext.Users.ToList();
            } catch (Exception ex) {

                throw new Exception(ex.ToString());
            }
            return result;
        }

        public List<User> GetActiveUsers() {
            throw new NotImplementedException();
        }
        public List<User> GetInActiveUsers() {
            throw new NotImplementedException();
        }
        #endregion
    }
}
