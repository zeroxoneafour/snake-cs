using Microsoft.Extensions.DependencyInjection;

namespace Snake.View;

public static class ViewBootstrapper
{
    public static void RegisterServices(IServiceCollection serviceCollection)
    {
        serviceCollection.AddSingleton<IView, View>();
    }
}