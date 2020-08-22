using System;

namespace SampleApp
{
    public delegate string MyDel(string str);

    class EvEx1
    {
        event MyDel MyEvent;

        public EvEx1()
        {
            this.MyEvent += new MyDel(this.WelcomeUser);
        }
        public string WelcomeUser(string username)
        {
            return "Welcome " + username;
        }
        static void Main(string[] args)
        {
            EvEx1 obj1 = new EvEx1();
            string result = obj1.MyEvent("To Bizzz");
            Console.WriteLine(result);
        }
    }
}