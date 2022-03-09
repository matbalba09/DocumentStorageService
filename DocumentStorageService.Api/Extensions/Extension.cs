namespace DocumentStorageService.Extensions
{
    public static class TestExtensions
    {
        public static IServiceCollection AddDevDatabase(
           this IServiceCollection services,
           IConfiguration configuration)
        {
            services.AddDbContext<DocumentStorageServiceContext>(options =>
                options.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));
            return services;
        }
    }
}
