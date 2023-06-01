using System;

namespace Enemies
{
    public class Zombie
    {
        private int health;
        private string name;

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
        public int GetHealth()
        {
            return this.health;
        }
        public string Name()
        {
            get { return name; }
            set { name = value; }
        }
        public override string ToString()
        {
            return $"Zombie Name: {this.Name} / Total Health: {this.Health}"
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
            newObject1.Name = "Ed";
            Console.WriteLine("{0} is of type {1} and has a total of {2} health", newObject1.Name, newObject1.GetType(), newObject1.GetHealth());
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        try
        {
            newObject2 = new Enemies.Zombie(98);
            Console.WriteLine("{0} is of type {1} and has a total of {2} health", newObject2.Name, newObject2.GetType(), newObject2.GetHealth());

        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}