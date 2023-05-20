using System;

/// <summary>
/// The Enemies namespace.
/// </summary>
namespace Enemies
{
    /// <summary>
    /// Class Zombie.
    /// Represents a zombie enemy in the game.
    /// </summary>
    public class Zombie
    {
        public int health;

        public Zombie()
        {
            this.health = 0;
        }

    }
}

class Program
{
    static void Main(string[] args)
    {
        Enemies.Zombie newObject = new Enemies.Zombie();

        Console.WriteLine("newObject is of type {0} and has a total of {1} health", newObject.GetType(), newObject.health);
    }
}