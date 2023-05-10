using System;
class Program
{
    static void Main(string[] args)
    {
        float number = 3.14159f;
        string formattedNumber = number.ToString("F2");
        Console.WriteLine(string.Format("Float: {0}", formattedNumber));
    }
}