using System;

class Program 
{         
    static void Main(string[] args)
    {

        for (int number = 0; number <= 99; number++)
        {
            if (number != 99)
            {
                Console.Write(number.ToString("D2") + ", ");
            }
            else
            {
                Console.Write("99");
            }
        }
    }
}
