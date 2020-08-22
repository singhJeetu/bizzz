using System;
using System.Collections.Generic;

public class HashSetExample
{
    public static void Main(string[] args)
    { 
        var names = new HashSet<string>();
        names.Add("jeetu");
        names.Add("Ankit");
        names.Add("Peter");
        names.Add("Irfan");
        names.Add("Ankit");  //duplicate element will not be added  
  
        foreach (var name in names)
        {
            Console.WriteLine(name);
        }
    }
}