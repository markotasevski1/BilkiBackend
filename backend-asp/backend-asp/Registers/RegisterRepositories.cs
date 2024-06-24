
using backend_asp.Infrastructure.Repository.Implementation;
using backend_asp.Infrastructure.Repository.Interface;

namespace backend_asp.Registers
{
    public static class RegisterRepositories
    {

        public static IServiceCollection RegisterRepository(this IServiceCollection services, IConfiguration configuration)
        {
            return services.RegisterRepositoriesForUse();
        }

        private static IServiceCollection RegisterRepositoriesForUse(this IServiceCollection services) =>
            services.AddScoped<IProductRepository, ProductRepository>();
    }
}
