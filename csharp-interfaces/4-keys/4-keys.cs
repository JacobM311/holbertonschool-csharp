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