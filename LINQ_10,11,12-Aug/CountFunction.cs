using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class CountFunction
    {
        static void Main(string[] args)
        {
            int[] Num = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Console.WriteLine("Find the count of the elements:");
            int Count = Num.Count();
            Console.WriteLine(Count);
            Console.ReadLine();
        }
    }
}