using System;

class Program
{
    static void Main(string[] args)
    {
        for (char i = 'a'; i <= 'z'; i++)
        {
            if (i == 'e' || i == 'q')
            {
                continue;
            }
            
            Console.Write(i);
        }
    }
}