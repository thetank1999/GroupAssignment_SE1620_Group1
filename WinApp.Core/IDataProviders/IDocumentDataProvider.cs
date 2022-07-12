using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinApp.SqlProvider;

namespace WinApp.Core
{
    public interface IDocumentDataProvider
    {
        #region [Add - Update - Remove ]
        public void AddDocument(Document Document);

        public void RemoveDocument(Document Document);

        public void UpdateDocument(Document Document);

       
        #endregion

        #region [ Get Single]
        public Document GetDocumentById(int id);
        #endregion

        #region [Activate - InActivate ]
        public void InActivateDocument(Document Document);
        public void ActiveDocument (Document Document);
        #endregion

        #region [ Get List ]
        public List<Document> GetAllDocuments();

        public List<Document> GetActiveDocuments();

        public List<Document> GetInActiveDocuments();

        public List<Document> GetDocumentsByUploaderId(int id);
        
        public List<Document> GetDocumentsByApproverId(int id);

        public List<Document> GetDocumentsByCategoryId(int id);

        public List<Document> GetDocumentsByMajorId(int id);

        public List<Document> GetNotApprovedDocumentsByUploader(int id);

        public List<Document> GetApprovedDocumentsByUploader(int id);

        public List<Document> GetAllApprovedDocument();

        public List<Document> GetAllApprovedDocumentByMajor(int majorId);

        public List<Document> GetAllApprovedDocumentByCategory(int categoryId);
        #endregion
    }
}
