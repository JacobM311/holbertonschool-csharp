using System;
using System.Collections.Generic;

public class List
{
    public static List<int> CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }

        List<int> intList = new List<int>();

        for (int i = 0; i < size; i++)
        {
            intList.Add(i);
            Console.Write(i + " ");
        }

        Console.WriteLine();

        return intList;
    }
}