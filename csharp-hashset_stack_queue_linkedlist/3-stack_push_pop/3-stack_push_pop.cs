using System;
using System.Collections.Generic;

public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
{
    int count = aStack.Count;
    Console.WriteLine("Number of items: " + count);

    if (count > 0)
    {
        string topItem = aStack.Peek();
        Console.WriteLine("Top item: " + topItem);

        bool containsSearch = aStack.Contains(search);
        Console.WriteLine("Stack contains \"" + search + "\": " + containsSearch);

        if (containsSearch)
        {
            Stack<string> tempStack = new Stack<string>();

            while (aStack.Count > 0 && aStack.Peek() != search)
            {
                tempStack.Push(aStack.Pop());
            }

            if (aStack.Count > 0)
            {
                tempStack.Push(aStack.Pop());
            }

            while (tempStack.Count > 0)
            {
                aStack.Push(tempStack.Pop());
            }
        }
    }
    else
    {
        Console.WriteLine("Stack is empty");
    }

    aStack.Push(newItem);

    return aStack;
}
