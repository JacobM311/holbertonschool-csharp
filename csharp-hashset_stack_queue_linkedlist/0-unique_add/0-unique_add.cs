using System;
using System.Collections.Generic;

public class List
{
    public static int Sum(List<int> myList)
    {
        HashSet<int> uniqueIntegers = new HashSet<int>();
        int sum = 0;

        foreach (int num in myList)
        {
            if (!uniqueIntegers.Contains(num))
            {
                uniqueIntegers.Add(num);
                sum += num;
            }
        }

        return sum;
    }
}