using System;
public struct StructsRectangle
{
    public int width, height;

}
public class TestStructs
{
    public static void Main()
    {
        StructsRectangle r = new StructsRectangle();
        r.width = 4;
        r.height = 5;
        Console.WriteLine("Area of Rectangle is: " + (r.width * r.height));
    }
}