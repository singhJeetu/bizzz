﻿using System;
using System.Reflection.Metadata.Ecma335;
using System.Threading;
using System.Threading.Tasks;

namespace TaskAsyncProg
{
    class TaskEx3
    {
        public static void Main(string[] args)
        {
            Calculate();
            Console.Read();
        }
        static void Calculate()
        {
            var task1 = Task.Run(() =>
            {
                return Calculate1();
            });

            var awaiter1 = task1.GetAwaiter();
            awaiter1.OnCompleted(() =>
            {
                var result1 = awaiter1.GetResult();
                Calculate2(result1);
            });

            Calculate3();
        }
        static int Calculate1()
        {
            Thread.Sleep(2000);
            Console.WriteLine("Calculating result1");
            return 100;
        }
        static int Calculate2(int result1)
        {
            Console.WriteLine("Calculating result2");
            return result1*2;
        }
        static int Calculate3()
        {
            Console.WriteLine("Calculating result3");
            return 300;
        }
    }
}