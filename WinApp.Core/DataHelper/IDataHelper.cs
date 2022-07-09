using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinApp.Core
{
    public interface IDataHelper
    {
        #region [ Validation ]
        public bool EmailValidation(string email);
        #endregion

        #region [ Convert to byte[] ]

        #endregion
    }
}
