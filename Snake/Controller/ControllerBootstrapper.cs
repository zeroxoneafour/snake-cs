using Microsoft.Extensions.DependencyInjection;

namespace Snake.Controller;

public static class ControllerBootstrapper
{
    public static void RegisterServices(IServiceCollection serviceCollection)
    {
        serviceCollection.AddSingleton<IController, Controller>();
    }
}