using System;
using System.Collections.Generic;

class List
{
    public static List<bool> DivisibleBy2(List<int> myList)
    {
        List<bool> result = new List<bool>();

        foreach (int number in myList)
        {
            result.Add(number % 2 == 0);
        }

        return result;
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<int> myList = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        List<bool> result = List.DivisibleBy2(myList);

        for (int i = 0; i < myList.Count; i++)
        {
            if (result[i])
                Console.WriteLine(myList[i] + " is divisible by 2");
            else
                Console.WriteLine(myList[i] + " is not divisible by 2");
        }
    }
}