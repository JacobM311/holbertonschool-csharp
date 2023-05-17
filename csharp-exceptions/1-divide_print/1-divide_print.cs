using System.Collections.Generic;
using System;

public class Int
{
    public static void divide(int a, int b)
    {
        int result = 0;
        try
        {
            result = a / b;
            Console.Write(String.Format("{0} / {1} = ", a, b));
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Cannot divide by zero");
            Console.Write(String.Format("{0} / {1} = ", a, b));
        }
        finally
        {
            Console.WriteLine(result);
        }
    }
}