using System;
class ApplicationEx
{
    static void Main(string[] args)
    {
        Console.Write("Enter 1st No:");
        int x = int.Parse(Console.ReadLine());
        Console.Write("Enter 2nd No:");
        int y = int.Parse(Console.ReadLine());

        if(y % 2 > 0)
        {
            throw new ApplicationException("Divisor value can't be odd no");
        }
        int z = x / y;
        Console.WriteLine("The Result is:" + z);
        Console.WriteLine("End of the program");

    }
}
