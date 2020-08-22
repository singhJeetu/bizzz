using System;
namespace Event_Delegates
{
    public delegate double Delegate1(int x, float y, double z);
    public delegate void Delegate2(int x, float y, double z);
    public delegate bool Delegate3(string str);
    class GenericDelegates1
    {
        public static double AddNums1(int x, float y, double z)
        {
            return x + y + z;
        }
        public static void AddNums2(int x, float y, double z)
        {
            Console.WriteLine(x + y + z);
        }
        public static bool CheckLength(string str)
        {
            if (str.Length > 5)
                return true;
                return false;
        }
        static void Main(string[] args)
        {
            Delegate1 obj1 = AddNums1;   //or new DelegatesProj.Delegate1(AddNums1);
            double result = obj1.Invoke(100, 34.2f, 129.221);
            Console.WriteLine(result);

            Delegate2 obj2 = AddNums2;
            obj2.Invoke(100, 32.2f, 129.221);

            Delegate3 obj3 = CheckLength;
            bool status = obj3.Invoke("Hello World");
            
            Console.WriteLine(status);
            Console.ReadLine();
        }
    }
}
               