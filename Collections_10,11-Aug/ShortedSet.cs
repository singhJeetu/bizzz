using System;
using System.Collections.Generic;

public class SortedSet
{
    public static void Main(string[] args)
    {
        
        var names = new SortedSet<string>();
        names.Add("jeet");
        names.Add("Ankit");
        names.Add("Peter");
        names.Add("Irfan");
        names.Add("Ankit");    //will not be added  

          
        foreach (var name in names)
        {
            Console.WriteLine(name);
        }
    }
}