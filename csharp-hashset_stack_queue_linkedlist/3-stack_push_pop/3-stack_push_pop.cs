using System;
using System.Collections.Generic;

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

        // If aStack contains the given item search, remove all items up to and including search
        if (containsSearch)
        {
            Queue<string> tempQueue = new Queue<string>();
            string item;
            do
            {
                item = aStack.Pop();
                tempQueue.Enqueue(item);
            }
            while (!item.Equals(search));
            
            // Place items back into aStack
            while (tempQueue.Count > 0)
            {
                aStack.Push(tempQueue.Dequeue());
            }
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