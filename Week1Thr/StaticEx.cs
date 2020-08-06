using System;
public class StaticEx
{
    public int accno;
    public String name;
    public static float rateOfInterest = 8.8f;
    public StaticEx(int accno, String name)
    {
        this.accno = accno;
        this.name = name;
    }
    public void display()
    {
        Console.WriteLine(accno + " " + name + " " + rateOfInterest);
    }
}
class TestAccount
{
    public static void Main(string[] args)
    {
        StaticEx.rateOfInterest = 10.5f;                //changing value  
        StaticEx a1 = new StaticEx(101, "jeet");
        StaticEx a2 = new StaticEx(102, "singh");
        a1.display();
        a2.display();

    }
}