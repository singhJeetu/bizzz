
using System;  
  public class SwitchClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a number:");
        int num = Convert.ToInt32(Console.ReadLine());

        switch (num)
        {
            case 1: Console.WriteLine("It is 1"); 
            break;
            case 2: Console.WriteLine("It is 2"); 
            break;
            case 3: Console.WriteLine("It is 3");
            break;
            default: Console.WriteLine("Not 1, 2 or 3"); 
            break;
        }
    }
}