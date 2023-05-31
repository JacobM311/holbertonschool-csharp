using System;

public class Player
{
    private string name { get; set; }
    private float maxHp { get; set; }
    public float hp { get; private set; }

    public Player() : this("Player", 100f){}
    public Player(string name) : this(name, 100f){}
    public Player(float maxHp) : this("Player", maxHp){}

    public Player(string name, float maxHp)
    {
        if (maxHp <= 0)
        {
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
            maxHp = 100f;
        }
        this.name = name;
        this.maxHp = maxHp;
        this.hp = maxHp;
    }

    public void PrintHealth()
    {
        Console.WriteLine($"{name} has {hp} / {maxHp} health");
    }
}