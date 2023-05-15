﻿using System;
using System.Collections.Generic;



public class List
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
        List<int> myList = new List<int>() {1, 2, 3, 4, 5, 6};
        List<bool> result = new List<bool>();
        int i;

        result = List.DivisibleBy2(myList);

        for (i = 0; i < myList.Count; i++)
        {
            if (result[i] == true)
                Console.WriteLine(myList[i] + " is divisible by 2");
            else
                Console.WriteLine(myList[i] + " is not divisible by 2");
        }
    }
}