using System;
public class Remove
{
    public static void Main(string[] args)
    {
        string s1 = "abcdefghijk";
        string s2 = s1.Remove(4, 5);
        Console.WriteLine(s2);
    }
}