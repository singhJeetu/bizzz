using System;
namespace Event_Delegates
{
    class GenericDelegates2
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
            Func<int, float, double, double> obj1 = AddNums1;
            double result = obj1.Invoke(100, 34.2f, 129.221);
            Console.WriteLine(result);

            Action<int, float, double> obj2 = AddNums2;
            obj2.Invoke(100, 32.2f, 129.221);

            Predicate<string> obj3 = CheckLength;
            bool status = obj3.Invoke("Hello World");

            Console.WriteLine(status);
            Console.ReadLine();
        }
    }
}
