using System;
using System.Collections.Generic;
using System.Linq;
using WinApp.Core;
using WinApp.SqlProvider;

namespace WinApp.DataProviders
{
    public class DocumentDataProvider : IDocumentDataProvider
    {
        #region [ Fields ]
        private readonly GroupAssignmentContext _dbContext;
        #endregion

        #region [ CTor ]
        public DocumentDataProvider(GroupAssignmentContext dbContext) {
            _dbContext = dbContext;
        }
        #endregion

        #region [Add - Update - Remove ]
        public void AddDocument(Document Document) {
            try {
                var dbEntity = _dbContext.Documents.FirstOrDefault(x => x.DocumentId == Document.DocumentId);
                if (dbEntity == null) {
                    _dbContext.Documents.Add(Document);
                    _dbContext.SaveChanges();
                } else {
                    throw new Exception();
                }
            } catch (Exception ex) {

                throw new Exception(ex.ToString());
            }
        }

        public void RemoveDocument(Document Document) {
            try {
                var dbEntity = _dbContext.Documents.FirstOrDefault(x => x.DocumentId == Document.DocumentId);
                if (dbEntity != null) {
                    _dbContext.Documents.Remove(Document);
                    _dbContext.SaveChanges();
                } else {
                    throw new Exception();
                }
            } catch (Exception ex) {

                throw new Exception(ex.ToString());
            }
        }
        public void UpdateDocument(Document Document) {
            try {
                var dbEntity = _dbContext.Documents.FirstOrDefault(x => x.DocumentId == Document.DocumentId);
                if (dbEntity != null) {
                    _dbContext.Documents.Update(Document);
                    _dbContext.SaveChanges();
                } else {
                    throw new Exception();
                }
            } catch (Exception ex) {

                throw new Exception(ex.ToString());
            }
        }
        #endregion

        #region [ Get Single]
        public Document GetDocumentById(int id) {
            Document document = null;
            try {
                document = _dbContext.Documents.FirstOrDefault(x => x.DocumentId == id);
            } catch (Exception ex) {

                throw new Exception(ex.ToString());
            }
            return document;
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
            var result = new List<Document>();
            try {
                result = _dbContext.Documents.ToList();
            } catch (Exception ex) {

                throw new Exception(ex.ToString());
            }
            return result;
        }

        public List<Document> GetActiveDocuments() {
            throw new NotImplementedException();
        }

        public List<Document> GetInActiveDocuments() {
            throw new NotImplementedException();
        }

        public List<Document> GetDocumentsByUploaderId(int id) {
            var result = new List<Document>();
            try {
                result = _dbContext.Documents.Where(x => x.UploaderId == id).ToList();
            } catch (Exception ex) {

                throw new Exception(ex.ToString());
            }
            return result;
        }

        public List<Document> GetDocumentsByApproverId(int id) {
            var result = new List<Document>();
            try {
                result = _dbContext.Documents.Where(x => x.ApproverId == id).ToList();
            } catch (Exception ex) {

                throw new Exception(ex.ToString());
            }
            return result;
        }

        public List<Document> GetDocumentsByCategoryId(int id) {
            var result = new List<Document>();
            try {
                result = _dbContext.Documents.Where(x => x.CategoryId == id).ToList();
            } catch (Exception ex) {

                throw new Exception(ex.ToString());
            }
            return result;
        }

        public List<Document> GetDocumentsByMajorId(int id) {
            var result = new List<Document>();
            try {
                result = _dbContext.Documents.Where(x => x.MajorId == id).ToList();
            } catch (Exception ex) {

                throw new Exception(ex.ToString());
            }
            return result;
        }

        public List<Document> GetNotApprovedDocumentsByUploader(int id) {
            var result = new List<Document>();
            try {
                result = _dbContext.Documents.Where(x => x.UploaderId == id && x.IsApproved == false).ToList();
            } catch (Exception ex) {

                throw new Exception(ex.ToString());
            }
            return result;
        }

        public List<Document> GetApprovedDocumentsByUploader(int id) {
            var result = new List<Document>();
            try {
                result = _dbContext.Documents.Where(x => x.UploaderId == id && x.IsApproved == true).ToList();
            } catch (Exception ex) {

                throw new Exception(ex.ToString());
            }
            return result;
        }
        #endregion
    }
}
