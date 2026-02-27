using System;

public partial class Character
{
    private string _name;
    private int _health;
    private int _level;

    public string Name { get; set; }
    public int Health { get; set; }
    public int Level { get; set; }

    public Character(string name, int health, int level)
    {
        Name = name;
        Health = health;
        Level = level;
    }
}

public partial class Character
{
    public void TakeDamage(int damage)
    {
        Health -= damage;
        if (Health < 0)
        {
            Health = 0;
        }
        Console.WriteLine($"{Name}이(가) {damage}의 피해를 입음. 남은 체력: {Health}");
    }
    
    public void Heal(int amount)
    {
        Health += amount;
        Console.WriteLine($"{Name}이(가) {amount}만큼 회복함. 현재 체력: {Health}");
    }
}
