using FrontToBackEnd.Application.Base;
using Microsoft.Extensions.DependencyInjection;

namespace FrontToBackEnd.Application;
public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddTransient<BasePageHandler>();
        services.AddTransient<BaseStylesHandler>();

        return services;
    }
}
