using System;
using System.Collections.Generic;

public class StackExample
{
    public static void Main(string[] args)
    {
        Stack<string> names = new Stack<string>();
        names.Push("jeetu");
        names.Push("kumar");
        names.Push("singh");
        names.Push("Ratan");
        names.Push("rana");

        foreach (string name in names)
        {
            Console.WriteLine(name);
        }

        Console.WriteLine("Peek element: " + names.Peek());
        Console.WriteLine("Pop: " + names.Pop());
        Console.WriteLine("After Pop, Peek element: " + names.Peek());

    }
}