using System;
using System.Collections.Generic;

public class DictionaryExample
{
    public static void Main(string[] args)
    {
        Dictionary<string, string> names = new Dictionary<string, string>();
        names.Add("1", "jeetu");
        names.Add("2", "kumar");
        names.Add("3", "singh");
        names.Add("4", "ratan");
        names.Add("5", "rajpoot");

        foreach (KeyValuePair<string, string> kv in names)
        {
            Console.WriteLine(kv.Key + " " + kv.Value);
        }
    }
}