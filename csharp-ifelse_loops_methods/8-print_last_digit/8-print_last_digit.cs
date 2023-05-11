using System;

class Number
{
    public static int PrintLastDigit(int number)
    {
        int lastdigit = Math.Abs(number) % 10;
        Console.Write(lastdigit);
        return lastdigit;
    }
}