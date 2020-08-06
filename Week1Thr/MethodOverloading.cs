using System;
public class Cal
{
    public static int add(int a, int b)
    {
        return a + b;
    }
    public static float add(float a, float b)
    {
        return a + b;
    }
}
public class TestOverloading
{
    public static void Main()
    {
        Console.WriteLine(Cal.add(111, 213));
        Console.WriteLine(Cal.add(12.4f, 21.3f));
    }
}