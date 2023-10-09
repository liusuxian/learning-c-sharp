using System;

namespace RectangleNamespace
{
    public class Rectangle
    {
        // 成员变量
        private double length;
        private double width;

        public void Acceptdetails()
        {
            //length = 4.5;
            //width = 3.5;
            Console.WriteLine("Enter length: ");
            length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter width: ");
            width = Convert.ToDouble(Console.ReadLine());
        }

        public double GetArea()
        {
            return length * width;
        }

        public void Display()
        {
            Console.WriteLine("Length: {0}", length);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Area: {0}", GetArea());
        }
    }
}