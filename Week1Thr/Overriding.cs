using System;
public class Elephant
{
    public virtual void eat()
    {
        Console.WriteLine("Eating...");
    }
}
public class Cat : Elephant
{
    public override void eat()
    {
        Console.WriteLine("Eating bread...");
    }
}
public class TestOverriding
{
    public static void Main()
    {
        Elephant e = new Elephant();
        e.eat();
    }
}