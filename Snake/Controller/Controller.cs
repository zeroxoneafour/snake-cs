using Snake.Game;
using Snake.View;

namespace Snake.Controller;

internal class Controller(IGame game, IView view) : IController
{
    public void LogStatus()
    {
        game.LogStatus();
        view.LogStatus();
    }
}