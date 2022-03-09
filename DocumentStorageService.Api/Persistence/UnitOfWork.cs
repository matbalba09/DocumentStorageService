using DocumentStorageService.Core;
using DocumentStorageService.Core.Repositories;
using DocumentStorageService.Persistence.Repositories;

namespace DocumentStorageService.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        protected readonly DocumentStorageServiceContext _context;

        public UnitOfWork(DocumentStorageServiceContext context)
        {
            _context = context;
            document = new DocumentRepository(_context);
        }

        public IDocumentRepository document { get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
