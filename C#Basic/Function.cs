using System;
namespace Function
{
    class Program
    {
        public void Show()  
        {
            Console.WriteLine("This is non parameterized function");
             
        }
       static void Main(string[] args)
        {
            Program program = new Program(); 
            program.Show();             
        }
    }
}