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