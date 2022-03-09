using DocumentStorageService.Api.Core;
using DocumentStorageService.Api.Core.Repositories;
using DocumentStorageService.Api.Persistence.Repositories;

namespace DocumentStorageService.Api.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        protected readonly PlutoContext _context;

        public UnitOfWork(PlutoContext context)
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
