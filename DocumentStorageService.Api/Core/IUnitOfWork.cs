using DocumentStorageService.Api.Core.Repositories;

namespace DocumentStorageService.Api.Core
{
    public interface IUnitOfWork : IDisposable
    {
        IDocumentRepository document { get; }

        int Complete();
    }
}
