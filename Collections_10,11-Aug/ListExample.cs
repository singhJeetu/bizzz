using System;
using System.Collections.Generic;

public class ListExample
{
    public static void Main(string[] args)
    {
          
        var names = new List<string>();    // Create a list of strings
        names.Add("Good Morning");
        names.Add("Good morning");
        names.Add("Ankit");
        names.Add("Kumar");
        names.Add("Singh");

          
        foreach (var name in names)  // Iterate list element using foreach loop
        {
            Console.WriteLine(name);
        }
    }
}