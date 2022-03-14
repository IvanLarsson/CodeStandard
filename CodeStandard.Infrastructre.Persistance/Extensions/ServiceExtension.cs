using CodeStandard.Domain.Repositories;
using CodeStandard.Infrastructre.Persistance.Context;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CodeStandard.Infrastructre.Persistance.Extensions
{
    public static class ServiceExtension
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<ICodeStandardDbContext, CodeStandardDbContext>(options => options.UseInMemoryDatabase(databaseName: "Test"));
            services.AddTransient<IMyPocoRepository, Repository>();
            return services;
        }

    }
}
