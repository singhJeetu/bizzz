using System;
class DeleEx1
{ 
    public delegate void PrintWord(int value);  // declare delegate 

    static void Main(string[] args)
    { 
        PrintWord printDel = PrintNum;     // Print delegate points to PrintNum 

        printDel(100000);
        printDel(200);
  
        printDel = PrintMoney;   

        printDel(10000);
        printDel(200);
    }

    public static void PrintNum(int num)
    {
        Console.WriteLine("Number: {0,-12:N0}", num);
    }

    public static void PrintMoney(int money)
    {
        Console.WriteLine("Money: {0:C}", money);
    }
}