using DocumentStorageService.Core.Domain;
using DocumentStorageService.Dto;

namespace DocumentStorageService.Core.Repositories
{
    public interface IDocumentRepository : IRepository<Document>
    {
        IEnumerable<Document> GetAllDocument();
        void AddDocument(Document document);

    }
}
