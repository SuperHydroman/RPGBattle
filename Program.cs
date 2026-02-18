using RPGBattle.Core;

namespace RPGBattle;

public static class Program
{
    public static void Main()
    {
        Console.WriteLine("Hi! Welcome to RPGBattle");
        
        Game game = new Game();
        game.StartGame();
    }
}