using RPGBattle.Characters;
using RPGBattle.Utilities;

namespace RPGBattle.Core;

public static class Game
{
    private static string HeroName { get; set; }
    public static Logger GameLogger { get; } = new();

    public static void StartGame()
    {
        /*
         * Create player
         *  - Set the Hero Name
         *  - Choose the Hero Type
         *      - Hero Types can have different stats:
         *          - MaxHealth
         *          - Health
         *          - Defense
         *          - Speed
         *      - Hero Types can have different base moves?? (COMES LATER)
         */

        /*
         * Create player
         *  - Set a random Hero Name
         *  - Choose a random Hero Type
         *      - Hero Types can have different stats:
         *          - MaxHealth
         *          - Health
         *          - Defense
         *          - Speed
         *      - Hero Types can have different base moves?? (COMES LATER)
         */
        // Start Battle
        
        SetHeroName();
        
        Character player = new Character(HeroName, 100);
        Character enemy = new Character("Goblin", 100);
        
        Battle battle = new Battle(player, enemy);
        battle.StartBattle();
    }

    private static void SetHeroName()
    {
        while (true)
        {
            GameLogger.Text("Please fill in the name of your Hero:");
            string? nameInput = Console.ReadLine()?.Trim();

            if (string.IsNullOrWhiteSpace(nameInput)) {
                GameLogger.Text("Name can't be empty.");
                continue;
            }

            if (!GameLogger.AskYesNoQuestion($"Is the name \"{nameInput}\" correct? (Y/N)")) continue;
            
            GameLogger.Text($"Hero name set to: {nameInput}");
            HeroName = nameInput;
            break;
        }
    }
}