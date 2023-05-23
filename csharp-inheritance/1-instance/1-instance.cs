using System;
using System.Collections.Generic;

class Obj
{
    public static bool IsInstanceOfArray(object obj)
    {
        if(obj != null && obj.GetType().IsArray)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        var numArray = new int[10];
        var num = 10;
        var aList = new List<int>();

        if (Obj.IsInstanceOfArray(numArray))
            Console.WriteLine("{0} is an instance of type array or inherits from type array", nameof(numArray));
        else
            Console.WriteLine("{0} is NOT an instance of type array nor inherits from type array", nameof(numArray));

        if (Obj.IsInstanceOfArray(num))
            Console.WriteLine("{0} is an instance of type array or inherits from type array", nameof(num));
        else
            Console.WriteLine("{0} is NOT an instance of type array nor inherits from type array", nameof(num));

        if (Obj.IsInstanceOfArray(aList))
            Console.WriteLine("{0} is an instance of type array or inherits from type array", nameof(aList));
        else
            Console.WriteLine("{0} is NOT an instance of type array nor inherits from type array", nameof(aList));
    }
}