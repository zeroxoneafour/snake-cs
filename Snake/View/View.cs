using Microsoft.Extensions.Logging;
using Snake.Game;

namespace Snake.View;

internal class View(ILogger<View> logger) : IView
{
    public void LogStatus()
    {
        logger.LogDebug("View is OK!");
    }
}