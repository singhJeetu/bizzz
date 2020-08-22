using System;
using System.Threading;
using System.Threading.Tasks;

namespace TaskAsyncProg
{
    class TaskEx
    {
        public static void Main(string[] args)
        {
            Calculate();
            Console.Read();
        }
        static void Calculate()
        {
            Task.Run(() =>
            { 
            Calculate1();
            });

            Task.Run(() =>
            {
                Calculate2();
            });

            Task.Run(() =>
            {
                Calculate3();
            });
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