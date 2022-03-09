using DocumentStorageService.Api.Core.Domain;
using DocumentStorageService.Api.Core.Repositories;
using System.Data.Entity;

namespace DocumentStorageService.Api.Persistence.Repositories
{
    public class DocumentRepository : Repository<Document>, IDocumentRepository
    {
        public DocumentRepository(PlutoContext context) : base(context)
        {
        }

        //public Document GetDocumentWithFileType(int id)
        //{
        //    return PlutoContext.document.SingleOrDefault(a => a.doc_id == id);//Include(a => a.file_types).SingleOrDefault(a => a.doc_id == id);
        //}
        public IEnumerable<Document> GetAllDocument()
        {
            return PlutoContext.document.ToList();
        }

        public void AddDocument(Document document)
        {
            PlutoContext.document.Add(document);
        }

        public PlutoContext PlutoContext
        {
            get { return _context as PlutoContext; }
        }
    }
}
