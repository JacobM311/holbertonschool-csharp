using System;
using System.Reflection;

class Obj
{
    public static void Print(object myObj)
    {
        TypeInfo typeInfo = myObj.GetType().GetTypeInfo();
        
        // Print class name
        Console.WriteLine("{0} Properties:", typeInfo.Name);

        // Loop through and print properties
        foreach (PropertyInfo property in typeInfo.GetProperties())
        {
            Console.WriteLine(property.Name);
        }

        // Print methods
        Console.WriteLine("{0} Methods:", typeInfo.Name);

        // Loop through and print methods
        foreach (MethodInfo method in typeInfo.GetMethods())
        {
            Console.WriteLine(method.Name);
        }
    }
}