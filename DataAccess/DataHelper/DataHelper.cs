using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinApp.Core;

namespace WinApp.DataProviders
{
    public class DataHelper : IDataHelper
    {
        #region [ Validation ]
        public bool EmailValidation(string email) {
            var trimmedEmail = email.Trim();

            if (trimmedEmail.EndsWith(".")) {
                return false; // suggested by @TK-421
            }
            try {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == trimmedEmail;
            } catch {
                return false;
            }
        }
        #endregion

        #region [ Convert to byte[] ]

        #endregion
    }
}
