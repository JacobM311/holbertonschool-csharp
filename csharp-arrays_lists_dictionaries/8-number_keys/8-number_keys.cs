using System;
using System.Collections.Generic;

public class Dictionary
{
    public static int NumberOfKeys(Dictionary<string, string> myDict)
    {
        int count = 0;
        foreach (KeyValuePair<string, string> pair in myDict)
        {
            count++;
        }
        return count;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, string> myDict = new Dictionary<string, string>();

        myDict.Add("language", "C");
        myDict.Add("track", "low level");
        myDict.Add("school", "Holberton");

        Console.WriteLine("Number of keys: {0}", Dictionary.NumberOfKeys(myDict));
    }
}