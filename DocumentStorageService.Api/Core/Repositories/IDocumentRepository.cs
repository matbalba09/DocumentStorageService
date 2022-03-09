using DocumentStorageService.Api.Core.Domain;
using DocumentStorageService.Api.Dto;

namespace DocumentStorageService.Api.Core.Repositories
{
    public interface IDocumentRepository : IRepository<Document>
    {
        IEnumerable<Document> GetAllDocument();
        void AddDocument(Document document);

    }
}
