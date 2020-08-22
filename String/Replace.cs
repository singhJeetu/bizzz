using System;
public class Replace
{
    public static void Main(string[] args)
    {
        string s1 = "Hello F#";
        string s2 = s1.Replace('F', 'C');
        Console.WriteLine(s2);
    }
}