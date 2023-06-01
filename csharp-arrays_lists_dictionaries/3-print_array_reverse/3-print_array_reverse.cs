using System;

public class Array
{
    public static void Reverse(int[] array)
    {
        if (array == null)
        {
            Console.WriteLine("Array is null");
            return;
        }

        for (int i = array.Length - 1; i >= 0; i--)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<int> newList;

        newList = List.CreatePrint(10);
        Console.WriteLine("List Length: " + newList.Count);
        Console.WriteLine("----------------");
        newList = List.CreatePrint(16);
        Console.WriteLine("List Length: " + newList.Count);
        Console.WriteLine("----------------");
        newList = List.CreatePrint(0);
        Console.WriteLine("List Length: " + newList.Count);
        Console.WriteLine("----------------");
        newList = List.CreatePrint(1);
        Console.WriteLine("List Length: " + newList.Count);        
    }
}