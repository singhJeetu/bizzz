using System;

public class Trim
{
    public static void Main(string[] args)
    {
        string s1 = "Hello ";
        string s2 = (s1.Trim()+ "Sir");
        Console.WriteLine(s2);
    }
}