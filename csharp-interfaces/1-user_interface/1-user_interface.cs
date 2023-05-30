using System;
using System.Collections.Generic;
using System.Reflection;

public abstract class Base
{
    public string name;

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

public class TestObject : Base, IBreakable, IInteractive, ICollectable
{
    public int durability { get; set; }
    public bool isCollected { get; set; }

    public void Break()
    {
        // provide implementation
    }

    public void Collect()
    {
        // provide implementation
    }

    public void Interact()
    {
        // provide implementation
    }
}