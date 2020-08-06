using System;
public class Calcu
{
    public static int add(int a, int b)
    {
        return a + b;
    }
    public static int add(int a, int b, int c)
    {
        return a + b + c;
    }
}
public class TestMemberOverloading
{
    public static void Main()
    {
        Console.WriteLine(Calcu.add(11, 22));
        Console.WriteLine(Calcu.add(12, 23, 25));
    }
}