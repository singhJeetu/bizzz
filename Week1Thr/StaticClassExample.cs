using System;
public static class StaticClassExample
{
    public static float I = 3.14f;
    public static int cue(int n)
    {
        return n * n * n; 
    }
}
class TestMyStaticClassExample
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Value of PI is: " + StaticClassExample.I);
        Console.WriteLine("Cube of 3 is: " + StaticClassExample.cue(3));
    }
}