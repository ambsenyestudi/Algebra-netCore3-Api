using Algebra.Application.Descriptors;
using Algebra.Application.Matrixes;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Algebra.API
{
    public static class ApplicationServicesStartup
    {
        public static void AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.ConfigureOptions(configuration)
            .AddMtxRowOperations()
            .AddDrescriptor();
        }

        private static IServiceCollection AddDrescriptor(this IServiceCollection services)
        {
            return services.AddTransient<IDescriptorsService, DescriptorsService>();
        }

        private static IServiceCollection AddMtxRowOperations(this IServiceCollection services)
        {
            return services.AddTransient<IMtxRowOperationServices, MtxRowOperationServices>();
        }

        private static IServiceCollection ConfigureOptions(this IServiceCollection services, IConfiguration configuration)
        {
            return services.Configure<ApiStateOptions>(configuration.GetSection("ApiStateConfig"));
        }
    }
}
