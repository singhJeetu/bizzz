using System;
using System.Threading.Tasks;
namespace MultiTasks 
{ 
    class Program 
    { 
        public static void Main(string[] args)
        {
            Task<string> obTask = Task.Run(() => 
            {
                return "Hello"; 
            });
            Console.WriteLine(obTask.Result); 
            Console.Write("Press any key to continue . . . ");
            //Console.ReadKey(true);
        }
    }
}