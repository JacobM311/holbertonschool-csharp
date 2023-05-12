using System;

class Program
{
    static void Main(string[] args)
    {
        int[] newArray;

        newArray = Array.CreatePrint(5);
        Console.WriteLine("Array Length: " + newArray.Length);
    }
}