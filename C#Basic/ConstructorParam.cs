using System;
public class ConstructorParam
{
    public int id;
    public String name;
    public int age;
    public ConstructorParam(int i, String n, int a)
    {
        id = i;
        name = n;
        age = a;
    }
    public void display()
    {
        Console.WriteLine(id + " " + name + " " + age);
    }
}
class TestEmployee
{
    public static void Main(string[] args)
    {
        ConstructorParam c1 = new ConstructorParam(101, "singh", 22);
        ConstructorParam c2 = new ConstructorParam(102, "ram", 23);
        c1.display();
        c2.display();

    }
}