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

public class Door : Base, IInteractive
{
    public Door() : this("Door"){}
    public Door(string name)
    {
        this.name = name;
    }

    public void Interact()
    {
        Console.WriteLine($"You try to open the {name}. It's locked.");
    }

}

public class Decoration : Base, IInteractive, IBreakable
{
    public bool isQuestItem { get; set; }
    public int durability { get; set; }

    public Decoration() : this("Decoration", 1, false){}
    public Decoration(string name, int durability) : this(name, 1, false){}
    public Decoration(string name) : this(name, 1, false){}
    public Decoration(string name, bool isQuestItem) : this(name, 1, isQuestItem){}
    public Decoration(int durability, bool isQuestItem) : this("Decoration", durability, isQuestItem){}

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
        durability--;

        if(durability > 0)
        {
            Console.WriteLine($"You hit the {name}. It cracks.");
        }
        else if(durability == 0)
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

public class Key : Base, ICollectable
{
    public bool isCollected { get; set; }

    public Key() : this("Key", false) { }
    public Key(string name) : this(name, false) { }
    public Key(bool isCollected) : this("Key", isCollected) { }

    public Key(string name, bool isCollected)
    {
        this.name = name;
        this.isCollected = isCollected;
    }

    public void Collect()
    {
        if (isCollected)
        {
            Console.WriteLine($"You have already picked up the {name}.");
        }
        else
        {
            isCollected = true;
            Console.WriteLine($"You pick up the {name}.");
        }
    }
}

public class RoomObjects
{
    public static void IterateAction(List<Base> roomObjects, Type type)
    {
        foreach (Base item in roomObjects)
        {
            if (type == typeof(IInteractive) && item is IInteractive interactive)
            {
                interactive.Interact();
            }
            else if (type == typeof(IBreakable) && item is IBreakable breakable)
            {
                breakable.Break();
            }
            else if (type == typeof(ICollectable) && item is ICollectable collectable)
            {
                collectable.Collect();
            }
        }
    }
}