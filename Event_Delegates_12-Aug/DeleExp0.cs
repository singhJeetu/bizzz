using System;
using System.Collections.Generic;
using System.Text;

namespace Event_Delegates
{
    //Step1.  defining a delegate
    public delegate void AddDelegate(int x, int y);
    public delegate string SayDelegate(string str);
    class DeleExp0
    {
        public void AddNums(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public static string SayHello(string name)
        {
            return "Hello" + name;
        }
        static void Main(string[] args)
        {
            DeleExp0 d = new DeleExp0();
            AddDelegate ad = new AddDelegate(d.AddNums);
            ad(100, 50);
                //Or
            //ad.Invoke(100, 50);
            SayDelegate sd = new SayDelegate(DeleExp0.SayHello);
            string str = sd("jeet"); //or sd.Invoke("jeet");
            Console.WriteLine(str);

                

        }
    }
}
