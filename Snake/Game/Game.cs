using Microsoft.Extensions.Logging;

namespace Snake.Game;

internal class Game(ILogger<Game> logger) : IGame
{
    private ISnake _snake = new Snake(new (0,0));

    public void LogStatus()
    {
        logger.LogDebug("Game is OK!");
    }
}