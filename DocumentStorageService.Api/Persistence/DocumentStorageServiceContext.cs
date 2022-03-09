using DocumentStorageService.Core.Domain;

namespace DocumentStorageService.Persistence
{
    public class DocumentStorageServiceContext : DbContext
    {
        public DocumentStorageServiceContext(DbContextOptions<DocumentStorageServiceContext> options) : base(options)
        {

        }

        public virtual DbSet<Document> document { get; set; }
        public virtual DbSet<FileType> file_type { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Configurations.Add(new Document());
        //}
    }
}
