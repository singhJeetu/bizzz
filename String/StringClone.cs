using System;
public class StringClone
{
    public static void Main(string[] args)
    {
        string s1 = "Hello ";
        string s2 = (String)s1.Clone();
        Console.WriteLine(s1);
        Console.WriteLine(s2);
    }
}