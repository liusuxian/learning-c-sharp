// See https://aka.ms/new-console-template for more information
using System;
using RectangleNamespace;
using DataTypeNamespace;
using TypeConversionNamespace;

namespace LearningCSharp
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      // 矩形
      Rectangle rectangle = new Rectangle();
      rectangle.Acceptdetails();
      rectangle.Display();
      // 基础数据类型
      DataType dataType = new DataType();
      dataType.DisplayBaseData();
      dataType.InitBaseData();
      dataType.DisplayBaseData();
      dataType.SizeBaseData();
      // 引用数据类型
      dataType.DisplayReferenceData();
      dataType.InitReferenceData();
      dataType.DisplayReferenceData();
      // 指针数据类型
      dataType.DisplayPointerData();
      dataType.InitPointerData();
      dataType.DisplayPointerData();
      // 类型转换
      TypeConversion typeConversion = new TypeConversion();
      typeConversion.Display();
      typeConversion.Conversion();
    }
  }
}