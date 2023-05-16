using System;
using System.Collections.Generic;

public class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        string bestKey = "None";
        int maxValue = int.MinValue;

        foreach (KeyValuePair<string, int> pair in myList)
        {
            if (pair.Value > maxValue)
            {
                bestKey = pair.Key;
                maxValue = pair.Value;
            }
        }

        return bestKey;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, int> myDict = new Dictionary<string, int>();

        myDict.Add("John", 12);
        myDict.Add("Alex", 8);
        myDict.Add("Bob", 14);
        myDict.Add("Molly", 16);
        myDict.Add("Mary", 14);

        Console.WriteLine("Best Score: {0}", Dictionary.BestScore(myDict));
    }
}