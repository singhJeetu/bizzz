using System;
using System.Threading;
using System.Threading.Tasks;

namespace TaskAsyncProg
{
    class Class1
    {
        static void Main(string[] args)
        {
            Method();
            Console.WriteLine("Main Method");
            Console.ReadLine();
        }
        public static void Method()
        {
            Task.Run(new Action(LongTask));
            Console.WriteLine("New Thread"); 
        }
        public static void LongTask()
        {
            Thread.Sleep(200000);
        }
    }
}