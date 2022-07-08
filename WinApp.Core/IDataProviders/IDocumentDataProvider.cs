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
        #region [Add - Update - Remove - InActivate]
        public void AddDocument(Document Document);

        public void RemoveDocument(Document Document);

        public void UpdateDocument(Document Document);

        public void InActivateDocument(Document Document);
        #endregion

        #region [ Get Single]
        public Document GetDocumentById(int id);
        #endregion

        #region [ Get List ]
        public List<Document> GetAllDocuments();

        public List<Document> GetActiveDocuments();

        public List<Document> GetDocumentsByUploaderId(int id);
        
        public List<Document> GetDocumentsByApproverId(int id);

        public List<Document> GetDocumentsByCategoryId(int id);

        public List<Document> GetDocumentsByMajorId(int id);

        public List<Document> GetNotApprovedDocumentsByUploader(int id);

        public List<Document> GetApprovedDocumentsByUploader(int id);
        #endregion
    }
}
