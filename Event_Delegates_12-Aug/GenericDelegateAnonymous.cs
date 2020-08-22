using System;
using System.Collections.Generic;
using System.Text;

namespace Event_Delegates
{

    class GenericDelegateAnonymous
    {
       
        static void Main(string[] args)
        {
            Func<int, float, double, double> obj1 = (x, y, z) =>
            {
                return x + y + z;
            };
            double result = obj1.Invoke(100, 34.2f, 129.221);
            Console.WriteLine(result);

            Action<int, float, double> obj2 = (x, y, z) =>
            {
                Console.WriteLine(x + y + z);
            };
            obj2.Invoke(100, 32.2f, 129.221);

            Predicate<string> obj3 = (str) =>
            {
                if (str.Length > 5)
                    return true;
                return false;
            };
            bool status = obj3.Invoke("Hello World");

            Console.WriteLine(status);
            Console.ReadLine();
        }
    }
}
