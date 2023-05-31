﻿using System;

public class Player
{
    public string name { get; private set; }
    public float maxHp { get; private set; }
    public float hp { get; private set; }

    public Player() : this("Player", 100f){}
    public Player(string name) : this(name, 100f){}

    public Player(string name, float maxHp)
    {
        if (maxHp <= 0)
        {
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
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

class Program
{
    static void Main(string[] args)
    {
        Player player1 = new Player("Electric Mouse", 500f);
        Player player2 = new Player("Water Turtle");

        player1.PrintHealth();
        player2.PrintHealth();
    }
}