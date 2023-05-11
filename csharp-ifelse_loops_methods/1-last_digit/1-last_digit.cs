using System;

class Program
{
    static void Main(string[] args)
    {
        Random rndm = new Random();
        int number = rndm.Next(-10000, 10000);
        int lastDigit = number % 10;
        string comparison = "";

        Console.Write("The last digit of {0} is ", number);
        
        if (lastDigit > 5)
        {
            comparison = "and is greater than 5";
        }
        else if (lastDigit == 0)
        {
            comparison = "and is 0";
        }
        else
        {
            comparison = "and is less than 6 and not 0";
        }
        
        Console.WriteLine("{0} {1}", lastDigit, comparison);
    }
}