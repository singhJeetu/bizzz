using System;
public class ExFinally1
{
    public static void Main(string[] args)
    {
        try
        {
            int a = 10;
            int b = 0;
            int x = a / b;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }

        finally
        {
            Console.WriteLine("Finally block is executed");
        }
        Console.WriteLine("Rest of the code");
    }
}