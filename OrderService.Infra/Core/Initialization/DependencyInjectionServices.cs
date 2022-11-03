using Microsoft.Extensions.DependencyInjection;
using OrderService.Domain.Core.Interfaces;
using OrderService.Extensisons;

namespace OrderService.Infra.Core.Initialization
{
    public static class DependencyInjectionServices
    {
        public static void AddInfraDependencies(this IServiceCollection services)
        {
            services.AddRepositories();
        }

        private static void AddRepositories(this IServiceCollection services)
        {
            IEnumerable<Type> assemblyTypes = typeof(DependencyInjectionServices).Assembly.GetNoAbstractTypes();
            services.AddImplementations(ServiceLifetime.Scoped, typeof(IBaseRepository), assemblyTypes);
        }
    }
}
