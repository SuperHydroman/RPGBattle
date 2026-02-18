namespace RPGBattle.Utilities;

public class Logger
{
    public void Text(string prompt)
    {
        Console.WriteLine(prompt);
    }

    public bool AskYesNoQuestion(string prompt)
    {
        Console.WriteLine(prompt);
        string? isCorrectInput = Console.ReadLine()?.Trim().ToLower();

        if (isCorrectInput is "y" or "yes")
            return true;
        
        Text("Let's try this again.");
        return false;
    }
}