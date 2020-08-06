using System;
public class Animal1
{
    public string color = "white";
}
public class Dog1 : Animal1
{
    string color = "black";
    public void showColor()
    {
        Console.WriteLine(base.color);
        Console.WriteLine(color);
    }

}
public class TestBase
{
    public static void Main()
    {
        Dog1 d = new Dog1();
        d.showColor();
    }
}