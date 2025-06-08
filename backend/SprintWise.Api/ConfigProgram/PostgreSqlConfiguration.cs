using Microsoft.EntityFrameworkCore;
using SprintWise.Dal;

namespace SprintWise.Api.ConfigProgram
{
    public static class PostgreSqlConfiguration
    {
        public static IServiceCollection ConfigurePostgreDataBase(this IServiceCollection services, WebApplicationBuilder builder)
        {
            services.AddDbContext<SWDbContext>(options => options.UseNpgsql(
                builder.Configuration.GetConnectionString("PostgreSQL"),
                b => b.MigrationsAssembly("SprintWise.Api"))
            );

            return services;
        }
    }
}
