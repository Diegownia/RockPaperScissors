using Games.Data.Core;

public class QuickDraw
{

    private IGameManager _gameManager;
    private IDrawer _drawer;
    private IQuickDrawTimeMechanic _quickDrawTimeMechanic;

    public QuickDraw(IGameManager gameManager, IDrawer drawer, IQuickDrawTimeMechanic quickDrawTimeMechanic)
    {
        _gameManager = gameManager;
        _drawer = drawer;
        _quickDrawTimeMechanic = quickDrawTimeMechanic;
    }

    public void Game()
    {
        Console.WriteLine("Welcome to the Quick Draw");
        Console.WriteLine("Your reflex matters!");
        Console.WriteLine("Let's set your difficulty: ");
        _quickDrawTimeMechanic.DifficultySetter(_gameManager.GetIntergerFromUserInput());

    }

    private void GameLoop()
    {

    }
}