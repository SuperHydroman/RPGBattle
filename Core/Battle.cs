using RPGBattle.Characters;

namespace RPGBattle.Core;

public class Battle(Character player, Character enemy)
{
    public void StartBattle()
    {
        Game.GameLogger.ClearConsole();
        Game.GameLogger.Text("\nLet the battle begin!\n");
        Game.GameLogger.Text($"The players \"{player.Name}\" and \"{enemy.Name}\" are ready to battle!");

        int round = 1;
        
        while (player.IsAlive && enemy.IsAlive)
        {
            Game.GameLogger.Text($"\n--- Round {round} ---\n");
            DisplayPlayerHealthBars();
            
            /*
             * Player attacks
             */
            int damage = player.Attack(enemy);
            Game.GameLogger.AttackResult(player, enemy, damage);
            
            // Stop the game if the _enemy died by the attack
            if (!enemy.IsAlive) break;
            
            /*
             * Enemy attacks
             */
            damage = enemy.Attack(player);
            Game.GameLogger.AttackResult(enemy, player, damage);
            Console.WriteLine();
            
            round++;
        }

        if (player.IsAlive && !enemy.IsAlive)
            Game.GameLogger.Text($"\"{player.Name}\" wins the battle!");
        else Game.GameLogger.Text($"\"{enemy.Name}\" wins the battle!");
    }

    private void DisplayPlayerHealthBars()
    {
        Game.GameLogger.Text($"{player.Name}: {player.Health} HP");
        Game.GameLogger.Text($"{enemy.Name}: {enemy.Health} HP");
    }
}