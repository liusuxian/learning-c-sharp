﻿// See https://aka.ms/new-console-template for more information
using System;
using RectangleNamespace;
using DataTypeNamespace;

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

      DataType dataType = new DataType();
      dataType.Display();
      dataType.InitData();
      dataType.Display();
      dataType.Size();
    }
  }
}