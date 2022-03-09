using DocumentStorageService.Core.Repositories;

namespace DocumentStorageService.Core
{
    public interface IUnitOfWork : IDisposable
    {
        IDocumentRepository document { get; }

        int Complete();
    }
}
