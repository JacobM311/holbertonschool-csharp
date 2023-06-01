using System;
using System.Collections.Generic;
using System.Linq;

public class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        // Print the number of items in aStack
        Console.WriteLine("Number of items: " + aStack.Count);

        // Print the item at the top of aStack without removing it
        if (aStack.Count > 0)
            Console.WriteLine("Top item: " + aStack.Peek());
        else
            Console.WriteLine("Stack is empty");

        // Print if aStack contains a given item search
        bool containsSearch = aStack.Contains(search);
        Console.WriteLine("Stack contains \"" + search + "\": " + containsSearch);

        // Convert stack to list
        List<string> list = aStack.ToList();

        // If aStack contains the given item search, remove all items up to and including search
        if (containsSearch)
        {
            int index = list.FindLastIndex(x => x.Equals(search));
            list.RemoveRange(index, list.Count - index);
        }

        // Clear the stack and push the items from the list back to the stack
        aStack.Clear();
        for (int i = list.Count - 1; i >= 0; i--)
        {
            aStack.Push(list[i]);
        }

        // Add a new given item newItem to aStack
        aStack.Push(newItem);

        return aStack;
    }
}



class Program
{
    // Main - entry point
    static void Main(string[] args)
    {
        Stack<string> aStack = new Stack<string>();

        aStack.Push("C");
        aStack.Push("HTML");
        aStack.Push("Javascript");
        aStack.Push("Python");
        aStack.Push("React");
        aStack.Push("Ruby");

        foreach (string item in aStack)
            Console.WriteLine(item);

        Console.WriteLine("------");

        MyStack.Info(aStack, "C#", "Javascript");

        Console.WriteLine("------");

        foreach (string item in aStack)
            Console.WriteLine(item);
    }
}