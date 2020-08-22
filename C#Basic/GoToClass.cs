using System;
public class GotoClass
{
    public static void Main(string[] args)
    {
    test:
        Console.WriteLine("You are not eligible to vote");

        Console.WriteLine("Enter your age:\n");
        int age = Convert.ToInt32(Console.ReadLine());
        if (age < 18)
        {
            goto test;
        }
        else
        {
            Console.WriteLine("You are eligible to vote!");
        }
    }
}