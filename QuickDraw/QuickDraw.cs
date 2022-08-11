using Games.Data.Core;

public class QuickDraw
{

    private IGameManager _gameManager;
    private IDrawer _drawer;

    public QuickDraw(IGameManager gameManager, IDrawer drawer)
    {
        _gameManager = gameManager;
        _drawer = drawer;
    }

    public void Game()
    {
        Console.WriteLine("Welcome to the Quick Draw");
        Console.WriteLine("Your reflex matters!");

    }

    private void GameLoop()
    {

    }
}