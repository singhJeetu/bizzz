using System;
using System.Collections.Generic;

public class LinkedList1
{
    public static void Main(string[] args)
    {
         
        var names = new LinkedList<string>();     // Create a list of strings 
        names.AddLast("jeetu rajpoot");
        names.AddLast("Ankit");
        names.AddLast("Anshuman");
        names.AddLast("Kunal");
        names.AddFirst("John");         //added to first index  

        
        foreach (var name in names)    // Iterate list element using foreach loop 
        {
            Console.WriteLine(name);
        }
    }
}