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
    public class MajorDataProvider : IMajorDataProvider
    {
        #region [ Fields ]
        private readonly GroupAssignmentContext _dbContext;
        #endregion

        #region [ CTor ]
        public MajorDataProvider(GroupAssignmentContext dbContext) {
            _dbContext = dbContext;
        }
        #endregion

        #region [Add - Update - Remove ]
        public void AddMajor(Major Major) {
            throw new NotImplementedException();
        }
        public void RemoveMajor(Major Major) {
            throw new NotImplementedException();
        }
        public void UpdateMajor(Major Major) {
            throw new NotImplementedException();
        }
        #endregion

        #region [Active- InActivate]
        public void InActivateMajor(Major Major) {
            throw new NotImplementedException();
        }
        public void ActivateMajor(Major Major) {
            throw new NotImplementedException();
        }
        #endregion

        #region [ Get Single]
        public Major GetMajorById(int id) {
            Major major = null;
            try {
                major = _dbContext.Majors.FirstOrDefault(x => x.MajorId == id);
            } catch (Exception ex) {

                throw new Exception(ex.ToString());
            }
            return major;
        }
        #endregion

        #region [ Get List ]
        public List<Major> GetAllMajors() {
            var result = new List<Major>();
            try {
                result = _dbContext.Majors.ToList();
            } catch (Exception ex) {

                throw new Exception(ex.ToString());
            }
            return result;
        }
        public List<Major> GetActiveMajors() {
            throw new NotImplementedException();
        }
        public List<Major> GetInActiveMajors() {
            throw new NotImplementedException();
        }
        #endregion
    }
}
