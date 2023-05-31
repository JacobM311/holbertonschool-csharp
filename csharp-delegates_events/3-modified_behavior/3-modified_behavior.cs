﻿using System;

public enum Modifier{
    Weak,
    Base,
    Strong
}

public delegate float CalculateModifier(float baseValue, Modifier modifier);

public class Player
{
    private string name { get; set; }
    private float maxHp { get; set; }
    public float hp { get; set; }
    public delegate void CalculateHealth(float amount);

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

    public float ApplyModifier(float baseValue, Modifier modifier)
    {
        if (modifier == Modifier.Weak)
        {
            return baseValue/2f;
        }
        else if (modifier == Modifier.Base)
        {
            return baseValue;
        }
        else
        {
            return baseValue * 1.5f;
        }
    }

    public void PrintHealth()
    {
        Console.WriteLine($"{name} has {hp} / {maxHp} health");
    }

    public void TakeDamage(float damage)
    {
        if (damage < 0)
        {
            Console.WriteLine($"{name} takes 0 damage!");
        }
        else
        {
            Console.WriteLine($"{name} takes {damage} damage!");
            hp = hp - damage;
            ValidateHP(hp);
        }
    }

    public void HealDamage(float heal)
    {
        if (heal < 0)
        {
            Console.WriteLine($"{name} heals 0 HP!");
        }
        else
        {
            Console.WriteLine($"{name} heals {heal} HP!");
            hp = hp + heal;
            ValidateHP(hp);
        }
    }

    public void ValidateHP(float newHp)
    {
        if (newHp < 0)
        {
            hp = 0;
        }
        else if (newHp > maxHp)
        {
            hp = maxHp;
        }
        else
        {
            hp = newHp;
        }
    }
}