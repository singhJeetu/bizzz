using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class AggregateFunction
    {
        static void Main(string[] args)
        {
            int[] num = new int[] {4, 9, 10, 1, 3, 6 };

            var result = num.Aggregate((a, b) => a + b);
            Console.WriteLine(result);
        }
    }
}