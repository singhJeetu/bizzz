using System;
public class Destructor
{
    public Destructor()
    {
        Console.WriteLine("Constructor Invoked");
    }
    ~Destructor()
    {
        Console.WriteLine("Destructor Invoked");
    }
}
class TestDestructor
{
    public static void Main(string[] args)
    {
        Destructor d1 = new Destructor();
        Destructor d2 = new Destructor();
    }
}