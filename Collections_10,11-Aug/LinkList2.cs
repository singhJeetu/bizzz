using System;
using System.Collections.Generic;

public class LinkedList2
{
    public static void Main(string[] args)
    {
         
        var names = new LinkedList<string>();     // Create a list of strings
        names.AddLast("Jeetu");
        names.AddLast("singh");
        names.AddLast("rajpoot");
        names.AddLast("Chandel");

        //insert new element before "Peter"  
        LinkedListNode<String> node = names.Find("Rajpoot");
        names.AddBefore(node, "Kumar");
        names.AddAfter(node, "Lucky");
 
        foreach (var name in names)
        {
            Console.WriteLine(name);
        }
    }
}