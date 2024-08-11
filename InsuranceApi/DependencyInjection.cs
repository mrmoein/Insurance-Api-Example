using System.Reflection;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace InsuranceApi;

public static class DependencyInjection
{
    public static IServiceCollection AddMainServices(
        this IServiceCollection services,
        IConfiguration configuration
    )
    {
        services.AddControllers();
        services.AddMemoryCache();

        services.AddAutoMapper(Assembly.GetExecutingAssembly());

        var applicationConnString = configuration.GetConnectionString("DefaultConnection");

        services.AddDbContext<ApplicationDbContext>(
            (sp, options) =>
            {
                options.AddInterceptors(sp.GetServices<ISaveChangesInterceptor>());

                options.UseMySql(
                    applicationConnString,
                    ServerVersion.AutoDetect(applicationConnString)
                );
            }
        );

        services.AddScoped<ApplicationDbContextInitialiser>();

        services.AddMiniProfiler(
                options => { options.RouteBasePath = "/profiler"; }
            )
            .AddEntityFramework();

        return services;
    }
}