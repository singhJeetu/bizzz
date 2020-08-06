using System;
public class This
{
    public int id;
    public String name;
    public int age;
    public This(int id, String name, int age)
    {
        this.id = id;
        this.name = name;
        this.age = age;
    }
    public void display()
    {
        Console.WriteLine(id + " " + name + " " + age);
    }
}
class TestThis
{
    public static void Main(string[] args)
    {
        This t1 = new This(101, "aman", 22);
        This t2 = new This(102, "Mahesh", 23);
        t1.display();
        t2.display();

    }
}