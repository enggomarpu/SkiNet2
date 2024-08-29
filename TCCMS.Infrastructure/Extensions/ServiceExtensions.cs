using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TCCMS.Domain.Interfaces;
using TCCMS.Infrastructure.Persistance;
using TCCMS.Infrastructure.Repositories;
using TCCMS.Infrastructure.Repositories.Products;

namespace TCCMS.Infrastructure.Extensions
{
    public static class ServiceExtensions
    {


        public static void AddInfrastructure(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<AppDbContext>(opts => opts.UseSqlServer(config.GetConnectionString("sqlConnection")));
            services.AddScoped<IProductRespository, ProductRepository>();
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
        }


    }
}
