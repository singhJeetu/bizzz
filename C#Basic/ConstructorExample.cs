using System;
public class ConstructorExample
{
    public ConstructorExample()
    {
        Console.WriteLine("Default Constructor Invoked");
    }
    public static void Main(string[] args)
    {
        ConstructorExample c1 = new ConstructorExample();
        ConstructorExample c2 = new ConstructorExample();
    }
}