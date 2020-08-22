using System;
using System.Threading;
using System.Threading.Tasks;

namespace TaskAsyncProg
{
    class Class2AsyncAwait
    {
        static void Main(string[] args)
        {
            Method();
            Console.WriteLine("Main Method");
            Console.ReadLine();
        }
        public static async void Method()
        {
            await Task.Run(new Action(LongTask));
            Console.WriteLine("New Thread");  //wait untill long task finishes
        }
        public static void LongTask()
        {
            Thread.Sleep(20000);
        }
    }
}