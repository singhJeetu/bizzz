using System;
using System.Threading;

namespace TaskAsyncProg
{
    class Class3AsyncAwait1
    {
        public static void Main(string[] args)
        {
            Calculate();
            Console.Read();
        }
        static void Calculate()
        {
            Calculate1();
            Calculate2();
            Calculate3();
        }
        static int Calculate1()
        {
            Thread.Sleep(2000);
            Console.WriteLine("Calculating result1");
            return 100;
        }
        static int Calculate2()
        {
            Console.WriteLine("Calculating result2");
            return 200;
        }
        static int Calculate3()
        {
            Console.WriteLine("Calculating result3");
            return 300;
        }
    }
}
