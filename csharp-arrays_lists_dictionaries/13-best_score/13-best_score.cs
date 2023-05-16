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