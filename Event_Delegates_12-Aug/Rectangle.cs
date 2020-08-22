using System;
using System.Collections.Generic;
using System.Text;

namespace Event_Delegates
{
    public delegate void RectDelegate(double Width, double Height);
    class Rectangle
    {
        public void GetArea(double Width, double Height)
        {
            Console.WriteLine("Area of Rectangle :" + Width * Height);
        }

        public void GetPerimeter(double Width, double Height)
        {
            Console.WriteLine("Perimeter of Rectangle: " + 2 * (Width + Height));
        }

        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            RectDelegate obj = new RectDelegate(rect.GetArea);
            obj += rect.GetPerimeter;
            obj.Invoke(12.43, 56.78);
            Console.WriteLine();

            obj.Invoke(10.11, 12.12);
            Console.ReadLine();

        }
    }
}