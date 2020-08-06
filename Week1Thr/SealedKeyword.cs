using System;
sealed public class Animal2
{
    public void eat()
    {
        Console.WriteLine("eating..."); 
    }
}
public class Dog2 : Animal2
{
    public void bark()
    {
        Console.WriteLine("barking...");
    }
}
public class TestSealed
{
    public static void Main()
    {
        Dog2 d = new Dog2();
        d.eat();
        d.bark();


    }
}