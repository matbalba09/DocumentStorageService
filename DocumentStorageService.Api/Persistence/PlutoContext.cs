using DocumentStorageService.Api.Core.Domain;

namespace DocumentStorageService.Api.Persistence
{
    public class PlutoContext : DbContext
    {
        public PlutoContext(DbContextOptions<PlutoContext> options) : base(options)
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
