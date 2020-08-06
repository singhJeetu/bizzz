using System;
public class StaticConstrucor
{
    public int id;
    public String name;
    public static float rateOfInterest;
    public StaticConstrucor(int id, String name)
    {
        this.id = id;
        this.name = name;
    }
    static StaticConstrucor()
    {
        rateOfInterest = 9.5f;
    }
    public void display()
    {
        Console.WriteLine(id + " " + name + " " + rateOfInterest);
    }
}
class TestEmployee
{
    public static void Main(string[] args)
    {
        StaticConstrucor a1 = new StaticConstrucor(101, "biz");
        StaticConstrucor a2 = new StaticConstrucor(102, "runtime");
        a1.display();
        a2.display();

    }
}