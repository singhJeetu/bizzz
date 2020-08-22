using System;
public class Join
{
    public static void Main(string[] args)
    {
        string[] s1 = { "Hello", "dost", "by", "jeet" };
        string s3 = string.Join("-", s1);
        Console.WriteLine(s3);
    }
}