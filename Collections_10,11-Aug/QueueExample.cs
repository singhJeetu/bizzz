using System;
using System.Collections.Generic;

public class QueueExample
{
    public static void Main(string[] args)
    {
        Queue<string> names = new Queue<string>();
        names.Enqueue("jeet");
        names.Enqueue("singh");
        names.Enqueue("rajpoot");
        names.Enqueue("Ratan");
        names.Enqueue("tata");

        foreach (string name in names)
        {
            Console.WriteLine(name);
        }

        Console.WriteLine("Peek element: " + names.Peek());
        Console.WriteLine("Dequeue: " + names.Dequeue());
        Console.WriteLine("After Dequeue, Peek element: " + names.Peek());
    }
}