using System;
public interface Drawable
{
    void draw();
}
public class Triangle : Drawable
{
    public void draw()
    {
        Console.WriteLine("drawing rectangle");
    }
}
public class Star : Drawable
{
    public void draw()
    {
        Console.WriteLine("drawing circle");
    }
}
public class TestInterface
{
    public static void Main()
    {
        Drawable d;
        d = new Triangle();
        d.draw();
        d = new Star();
        d.draw();
    }
}