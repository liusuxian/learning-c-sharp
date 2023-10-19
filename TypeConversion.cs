using System;

namespace TypeConversionNamespace
{
  public class TypeConversion
  {
    public void Display()
    {
      // 隐式类型转换
      byte b = 10;
      int i = b; // 隐式转换，不需要显式转换
      Console.WriteLine("b: {0}", b);
      Console.WriteLine("i: {0}", i);
      int intValueA = 42;
      long longValue = intValueA; // 隐式转换，从 int 到 long
      Console.WriteLine("intValueA: {0}", intValueA);
      Console.WriteLine("longValue: {0}", longValue);
      // 显式转换
      int j = 10;
      byte c = (byte)j; // 显式转换，需要使用强制类型转换符号
      Console.WriteLine("j: {0}", j);
      Console.WriteLine("c: {0}", c);
      double doubleValue = 3.14;
      int intValueB = (int)doubleValue; // 强制从 double 到 int，数据可能损失小数部分
      Console.WriteLine("doubleValue: {0}", doubleValue);
      Console.WriteLine("intValueB: {0}", intValueB);
      int intValueC = 42;
      float floatValue = (float)intValueC; // 强制从 int 到 float，数据可能损失精度
      Console.WriteLine("intValueC: {0}", intValueC);
      Console.WriteLine("floatValue: {0}", floatValue);
      int intValueD = 123;
      string stringValue = intValueD.ToString(); // 将 int 转换为字符串
      Console.WriteLine("intValueD: {0}", intValueD);
      Console.WriteLine("stringValue: {0}", stringValue);
    }
    public void Conversion()
    {
      double d = 2345.7652;
      Console.WriteLine("d: {0}", Convert.ToBoolean(d));
      Console.WriteLine("d: {0}", Convert.ToDecimal(d));
      Console.WriteLine("d: {0}", Convert.ToDouble(d));
      Console.WriteLine("d: {0}", Convert.ToInt16(d));
      Console.WriteLine("d: {0}", Convert.ToInt32(d));
      Console.WriteLine("d: {0}", Convert.ToInt64(d));
      Console.WriteLine("d: {0}", Convert.ToSingle(d));
      Console.WriteLine("d: {0}", Convert.ToString(d));
      Console.WriteLine("d: {0}", Convert.ToUInt16(d));
      Console.WriteLine("d: {0}", Convert.ToUInt32(d));
      Console.WriteLine("d: {0}", Convert.ToUInt64(d));
    }
  }
}