﻿using System;
using System.Threading;
using System.Threading.Tasks;

namespace TaskAsyncProg
{
    class TaskEx2
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

            var task2 = Task.Run(() =>
            {
                return Calculate2();
            });

            Task.WaitAll(task1, task2);

            var awaiter1 = task1.GetAwaiter();
            var awaiter2 = task2.GetAwaiter();
            var result1 = awaiter1.GetResult();
            var result2 = awaiter2.GetResult();

            Calculate3(result1, result2);
        }
        static int Calculate1()
        {
            Thread.Sleep(1000);
            Console.WriteLine("Calculating result1");
            return 100;
        }
        static int Calculate2()
        {
            Console.WriteLine("Calculating result2");
            return 200;
        }
        static int Calculate3(int result1, int result2)
        {
            Console.WriteLine("Calculating result3");
            return result1 + result2;
        }
    }
}