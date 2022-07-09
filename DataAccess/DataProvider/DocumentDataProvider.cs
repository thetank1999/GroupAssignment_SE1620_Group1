using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinApp.Core;
using WinApp.SqlProvider;

namespace WinApp.DataProviders
{
    public class DocumentDataProvider : IDocumentDataProvider
    {
        #region [Add - Update - Remove ]
        public void AddDocument(Document Document) {
            throw new NotImplementedException();
        }

        public void RemoveDocument(Document Document) {
            throw new NotImplementedException();
        }
        public void UpdateDocument(Document Document) {
            throw new NotImplementedException();
        }
        #endregion

        #region [ Get Single]
        public Document GetDocumentById(int id) {
            throw new NotImplementedException();
        }
        #endregion

        #region [Activate - InActivate ]
        public void InActivateDocument(Document Document) {
            throw new NotImplementedException();
        }
        public void ActiveDocument(Document Document) {
            throw new NotImplementedException();
        }
        #endregion

        #region [ Get List ]
        public List<Document> GetAllDocuments() {
            throw new NotImplementedException();
        }

        public List<Document> GetActiveDocuments() {
            throw new NotImplementedException();
        }

        public List<Document> GetInActiveDocuments() {
            throw new NotImplementedException();
        }

        public List<Document> GetDocumentsByUploaderId(int id) {
            throw new NotImplementedException();
        }

        public List<Document> GetDocumentsByApproverId(int id) {
            throw new NotImplementedException();
        }

        public List<Document> GetDocumentsByCategoryId(int id) {
            throw new NotImplementedException();
        }

        public List<Document> GetDocumentsByMajorId(int id) {
            throw new NotImplementedException();
        }

        public List<Document> GetNotApprovedDocumentsByUploader(int id) {
            throw new NotImplementedException();
        }

        public List<Document> GetApprovedDocumentsByUploader(int id) {
            throw new NotImplementedException();
        }
        #endregion
    }
}
