using System;
using System.Collections.Generic;

public class LList
{
    public static int GetNode(LinkedList<int> myLList, int n)
    {
        int index = 0;
        foreach (int item in myLList)
        {
            if (index == n)
            {
                return item;
            }
            index++;
        }
        return 0;
    }
}