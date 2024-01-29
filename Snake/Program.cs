using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Snake.Controller;
using Snake.Game;
using Snake.View;

IServiceCollection services = new ServiceCollection();
services.AddLogging(builder => builder.AddConsole());
GameBootstrapper.RegisterServices(services);
ViewBootstrapper.RegisterServices(services);
ControllerBootstrapper.RegisterServices(services);

IServiceProvider serviceProvider = services.BuildServiceProvider();

serviceProvider.GetService<IController>()!.LogStatus();