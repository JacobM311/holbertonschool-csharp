using System;
using System.Collections.Generic;

public class LList
{
    public static LinkedList<int> CreatePrint(int size)
    {
        LinkedList<int> myList = new LinkedList<int>();

        if (size <= 0)
            return myList;

        for (int i = 0; i < size; i++)
        {
            myList.AddLast(i);
            Console.Write(i + " ");
        }

        Console.WriteLine();
        return myList;
    }
}