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
        private readonly IDbContextFactory<GroupAssignmentContext> _dbContext;
        #endregion

        #region [ CTor ]
        public MajorDataProvider(IDbContextFactory<GroupAssignmentContext> dbContext) {
            this._dbContext = dbContext;
        }
        #endregion

        #region [Add - Update - Remove - InActivate]
        public void AddMajor(Major Major) {
            throw new NotImplementedException();
        }
        public void RemoveMajor(Major Major) {
            throw new NotImplementedException();
        }
        public void UpdateMajor(Major Major) {
            throw new NotImplementedException();
        }

        public void InActivateMajor(Major Major) {
            throw new NotImplementedException();
        }
        #endregion

        #region [ Get Single]
        public Major GetMajorById(int id) {
            throw new NotImplementedException();
        }
        #endregion

        #region [ Get List ]
        public List<Major> GetAllMajors() {
            throw new NotImplementedException();
        }

        public List<Major> GetActiveMajors() {
            throw new NotImplementedException();
        }
        #endregion
    }
}
