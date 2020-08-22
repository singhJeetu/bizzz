using System;
using System.Collections.Generic;
using System.Text;

namespace Event_Delegates
{
    public delegate string GreetingDelegate(string name);
    class AnonymousMethod
    {
       /* public static string Greetings(string name)
        {
            return "Hello" + name + "good morning";
        } */
        static void Main(string[] args)
        {
            GreetingDelegate obj = delegate (string name) //new GreetingDelegate(Greetings);
            {
                return "Hello" + name + "good morning";
            };
            string str = obj.Invoke("Jeetu");
            Console.WriteLine(str);
            Console.ReadLine();

        }
    }
}
