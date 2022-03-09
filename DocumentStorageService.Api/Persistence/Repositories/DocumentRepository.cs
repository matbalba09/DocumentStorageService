using DocumentStorageService.Core.Domain;
using DocumentStorageService.Core.Repositories;
using System.Data.Entity;

namespace DocumentStorageService.Persistence.Repositories
{
    public class DocumentRepository : Repository<Document>, IDocumentRepository
    {
        public DocumentRepository(DocumentStorageServiceContext context) : base(context)
        {
        }

        //public Document GetDocumentWithFileType(int id)
        //{
        //    return DocumentStorageServiceContext.document.SingleOrDefault(a => a.doc_id == id);//Include(a => a.file_types).SingleOrDefault(a => a.doc_id == id);
        //}
        public IEnumerable<Document> GetAllDocument()
        {
            return DocumentStorageServiceContext.document.ToList();
        }

        public void AddDocument(Document document)
        {
            DocumentStorageServiceContext.document.Add(document);
        }

        public DocumentStorageServiceContext DocumentStorageServiceContext
        {
            get { return _context as DocumentStorageServiceContext; }
        }
    }
}
