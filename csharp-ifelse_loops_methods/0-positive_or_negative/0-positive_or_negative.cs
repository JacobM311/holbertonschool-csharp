using System;

class Program
{
    static void Main(string[] args)
    {
        Random rndm = new Random();
        int number = rndm.Next(-10, 10);
        if (number == 0)
            Console.WriteLine("is zero");
        if (number > 0)
            Console.WriteLine("is positive");
        if (number < 0)
            Console.WriteLine("is negative");
    }
}