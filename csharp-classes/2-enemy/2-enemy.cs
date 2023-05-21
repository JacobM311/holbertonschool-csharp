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
        public Zombie(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Health must be greater than or equal to 0");
            }
            else
            {
                this.health = value;
            }
        }

    }
}

class Program
{
    static void Main(string[] args)
    {
        Enemies.Zombie newObject1;
        Enemies.Zombie newObject2;

        try
        {
            newObject1 = new Enemies.Zombie(10);
            Console.WriteLine("newObject1 is of type {0} and has a total of {1} health", newObject1.GetType(), newObject1.health);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        try
        {
            newObject2 = new Enemies.Zombie(-10);
            Console.WriteLine("newObject2 is of type {0} and has a total of {1} health", newObject2.GetType(), newObject2.health);

        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}