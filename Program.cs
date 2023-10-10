// See https://aka.ms/new-console-template for more information
using System;
using RectangleNamespace;

namespace LearningCSharp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Rectangle rectangle = new Rectangle();
            rectangle.Acceptdetails();
            rectangle.Display();
        }
    }
}
