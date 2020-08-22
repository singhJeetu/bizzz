using System;
using System.Collections.Generic;

public class SortedDictionaryEx
{
    public static void Main(string[] args)
    {
        SortedDictionary<string, string> names = new SortedDictionary<string, string>();
        names.Add("1", "jeetu");
        names.Add("4", "Kumar");
        names.Add("5", "Singh");
        names.Add("3", "Ratan");
        names.Add("2", "Rajpoot");
        foreach (KeyValuePair<string, string> kv in names)
        {
            Console.WriteLine(kv.Key + " " + kv.Value);
        }
    }
}