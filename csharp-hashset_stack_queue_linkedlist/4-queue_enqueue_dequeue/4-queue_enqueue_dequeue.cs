using System;
using System.Collections.Generic;

public class MyQueue
{
    public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
    {
        Console.WriteLine("Number of items: " + aQueue.Count);

        if (aQueue.Count > 0)
            Console.WriteLine("First item: " + aQueue.Peek());
        else
            Console.WriteLine("Queue is empty");

        aQueue.Enqueue(newItem);

        Console.WriteLine("Queue contains \"" + search + "\": " + aQueue.Contains(search));

        if (aQueue.Contains(search))
        {
            while (aQueue.Dequeue() != search) { }
        }

        return aQueue;
    }
}