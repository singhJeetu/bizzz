using System;
using System.Collections.Generic;

public class SortedListEx
{
    public static void Main(string[] args)
    {
        SortedList<string, string> names = new SortedList<string, string>();
        names.Add("1", "Jeet");
        names.Add("4", "Singh");
        names.Add("5", "Kumar");
        names.Add("3", "Ratan");
        names.Add("2", "Rajpoot");
        foreach (KeyValuePair<string, string> kv in names)
        {
            Console.WriteLine(kv.Key + " " + kv.Value);
        }
    }
}