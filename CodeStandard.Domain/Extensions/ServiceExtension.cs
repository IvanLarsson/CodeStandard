using CodeStandard.Domain.Services;

using Microsoft.Extensions.DependencyInjection;

namespace CodeStandard.Domain.Extensions
{
    /// <summary>
    ///     What is this??
    /// </summary>
    public static class ServiceExtension
    {
        public static IServiceCollection AddDomainServices(this IServiceCollection services)
            => services.AddTransient<IMyPocoService, MyPocoService>();

    }
}
