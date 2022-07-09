using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinApp.SqlProvider;

namespace WinApp.Core
{
    public interface IMajorDataProvider
    {
        #region [Add - Update - Remove ]
        public void AddMajor(Major Major);
        public void RemoveMajor(Major Major);
        public void UpdateMajor(Major Major);
        #endregion

        #region [Active- InActivate]
        public void InActivateMajor(Major Major);
        public void ActivateMajor(Major Major);
        #endregion

        #region [ Get Single]
        public Major GetMajorById(int id);
        #endregion

        #region [ Get List ]
        public List<Major> GetAllMajors();
        public List<Major> GetActiveMajors();
        public List<Major> GetInActiveMajors();
        #endregion
    }
}
