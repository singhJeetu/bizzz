using System;
namespace PracticeApp
{
    public class DoWhileLoop
    {
        public static void Main(string[] args)
        {
            int i = 1;

            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i <= 10);

        }
    }
}