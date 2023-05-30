using System;
using System.Collections.Generic;
using System.Reflection;

public abstract class Base
{
    public string name { get; set; }

    public override string ToString()
    {
        return $"{name} is a {this.GetType()}";
    }

}

public interface IInteractive
{
    void Interact();
}

public interface IBreakable
{
    int durability { get; set; }
    void Break();
}

public interface ICollectable
{
    bool isCollected { get; set; }
    void Collect();
}

public class Decoration : Base, IInteractive, IBreakable
{
    public bool isQuestItem { get; set; }
    public int durability { get; set; }

    public Decoration() : this("Decoration", 1, false){}
    public Decoration(string name, int durability) : this(name, 1, false){}
    public Decoration(string name) : this(name, 1, false){}
    public Decoration(string name, bool isQuestItem) : this(name, 1, isQuestItem){}

    public Decoration(string name, int durability, bool isQuestItem)
    {
        if (durability <= 0)
        {
            throw new Exception("Durability must be greater than 0");
        }
        this.name = name;
        this.durability = durability;
        this.isQuestItem = isQuestItem;
    }

    public void Break()
    {
        this.durability--;

        if(this.durability > 0)
        {
            Console.WriteLine($"You hit the {name}. It cracks.");
        }
        else if(this.durability == 0)
        {
            Console.WriteLine($"You smash the {name}. What a mess.");
        }
        else
        {
            Console.WriteLine($"The {name} is already broken.");
        }
    }

    public void Interact()
    {
        if (this.durability <= 0)
        {
            Console.WriteLine($"The {name} has been broken.");
        }
        else if (isQuestItem == true)
        {
            Console.WriteLine($"You look at the {name}. There's a key inside.");
        }
        else
        {
            Console.WriteLine($"You look at the {name}. Not much to see here.");
        }
    }
}