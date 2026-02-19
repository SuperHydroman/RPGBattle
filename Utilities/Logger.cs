using RPGBattle.Characters;
using RPGBattle.Core;

namespace RPGBattle.Utilities;

public class Logger
{
    public void Text(string prompt)
    {
        Console.WriteLine(prompt);
    }

    public bool AskYesNoQuestion(string prompt)
    {
        while (true)
        {
            Text(prompt);
            string? isCorrectInput = Console.ReadLine()?.Trim().ToLower();

            if (isCorrectInput is "y" or "yes")
                return true;

            if (isCorrectInput is "n" or "no")
                return false;
                
            Text("Please answer with Y(es) or N(o).");
        }
    }

    public void AttackResult(Character attacker, Character target, int damage)
    {
        string damageResult = damage > 0
            ? $" for '{damage}' damage!"
            : ", but missed!";

        Game.GameLogger.Text($"Player \"{attacker.Name}\" attacks \"{target.Name}\"{damageResult}");
    }

    public void ClearConsole()
    {
        Console.Clear();
    }
}