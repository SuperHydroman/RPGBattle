namespace RPGBattle.Characters;

public class Character(string name, int health)
{
    private readonly Random _random = new();
    
    public string Name { get; } = name;
    public int Health { get; private set; } = health;
    public int LastDamage { get; private set; } = 0;

    public bool IsAlive => Health > 0;

    public int Attack(Character target)
    {
        int damage = _random.Next(4, 10);
        bool missed = _random.Next(0, 100) < 20; // 20% miss chance

        if (missed)
            return 0;
        
        target.TakeDamage(damage);
        return damage;
    }

    public void TakeDamage(int amount)
    {
        LastDamage = amount;
        Health = Math.Max(0, Health - amount);
    }
}

