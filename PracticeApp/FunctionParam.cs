using System;
namespace FunctionParam
{
    class Program
    {  
        public string Show(string message)
        {
            Console.WriteLine("Inside Show Function");
            return message;
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            string message = program.Show("Sir");
            Console.WriteLine("Hello " + message);
        }
    }
}