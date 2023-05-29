using System;

class Queue<T>
{
    public Node head = null;
    public Node tail = null;
    public int count = 1;

    public int Count()
    {
        return count;
    }

    public void Enqueue(T value)
    {
        Node newNode = new Node(value);

        if (tail == null)
        {
            head = newNode;
            tail = newNode;
        }
        else
        {
            tail.next = newNode;
            tail = newNode;
            count++;
        }
    }

    public T Dequeue()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }
        T  value = head.value;

        head = head.next;
        count--;

        if (head == null)
        {
            tail = null;
        }

        return value;
    }

    public Type CheckType()
    {
        return typeof(T);
    }

    public class Node
    {
        public T value { get; set; }
        public Node next { get; set; }

        public Node(T val)
        {
            value = val;
            next = null;
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        Queue<int> myIntQ = new Queue<int>();

        myIntQ.Enqueue(100);
        myIntQ.Enqueue(101);
        Console.WriteLine("Number of nodes in queue: " + myIntQ.Count());

        Console.WriteLine("First value: " + myIntQ.Dequeue());
        Console.WriteLine("Number of nodes in queue: " + myIntQ.Count());

        Console.WriteLine("----------");

        Queue<float> myFloatQ = new Queue<float>();

        myFloatQ.Enqueue(9.8f);
        Console.WriteLine("Number of nodes in queue: " + myFloatQ.Count());

        Console.WriteLine("First value: " + myFloatQ.Dequeue());

        Console.WriteLine("Number of nodes in queue: " + myFloatQ.Count());

        Console.WriteLine("First value: " + myFloatQ.Dequeue());
    }
}