using System;

class Program
{
    static void Main(string[] args)
    {
        for (int x = 0; x <= 98; x++)
        {
            Console.Write(string.Format("{0} = 0x{1}{2}", x, x.ToString("x"), Environment.NewLine));
        }
    }
}