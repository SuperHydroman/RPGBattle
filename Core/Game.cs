using RPGBattle.Utilities;

namespace RPGBattle.Core;

public class Game
{
    private string? HeroName { get; set; }
    private readonly Logger _logger = new Logger();

    public void StartGame()
    {
        SetHeroName();
    }

    private void SetHeroName()
    {
        while (true)
        {
            _logger.Text("Please fill in the name of your Hero:");
            string? nameInput = Console.ReadLine()?.Trim();

            if (string.IsNullOrWhiteSpace(nameInput)) {
                _logger.Text("Name can't be empty.");
                continue;
            }

            if (!_logger.AskYesNoQuestion($"Is the name {nameInput} correct? (Y/N)")) continue;
            
            _logger.Text($"Hero name set to: {nameInput}");
            HeroName = nameInput;
            break;
        }
    }
}