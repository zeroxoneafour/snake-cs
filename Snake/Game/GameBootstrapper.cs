using Microsoft.Extensions.DependencyInjection;

namespace Snake.Game;

public static class GameBootstrapper
{
    public static void RegisterServices(IServiceCollection serviceCollection)
    {
        serviceCollection.AddSingleton<IGame, Game>();
    }
}