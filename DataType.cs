using System;

namespace DataTypeNamespace
{
  public class DataType
  {
    // 布尔值，True 或 False，默认 False
    private bool boolA;
    private bool boolB;
    // 8 位无符号整数，0 到 255，默认 0
    private byte byteA;
    // 16 位 Unicode 字符，U +0000 到 U +ffff，默认 '\0'
    private char charA;
    // 128 位精确的十进制值，28-29 有效位数，(-7.9 x 1028 到 7.9 x 1028) / 100 到 28，默认 0.0M
    private decimal decimalA;
    // 64 位双精度浮点型，(+/-)5.0 x 10-324 到 (+/-)1.7 x 10308，默认 0.0D
    private double doubleA;
    // 32 位单精度浮点型，-3.4 x 1038 到 + 3.4 x 1038，默认 0.0F
    private float floatA;
    // 32 位有符号整数类型，-2,147,483,648 到 2,147,483,647，默认 0
    private int intA;
    // 64 位有符号整数类型，-9,223,372,036,854,775,808 到 9,223,372,036,854,775,807，默认 0L
    private long longA;
    // 8 位有符号整数类型，-128 到 127，默认 0
    private sbyte sbyteA;
    // 16 位有符号整数类型，-32,768 到 32,767，默认 0
    private short shortA;
    // 32 位无符号整数类型，0 到 4,294,967,295，默认 0
    private uint uintA;
    // 64 位无符号整数类型，0 到 18,446,744,073,709,551,615，默认 0
    private ulong ulongA;
    // 16 位无符号整数类型，0 到 65,535，默认 0
    private ushort ushortA;
    // 初始化数据
    public void InitData()
    {
      boolA = true;
      boolB = false;
      byteA = 96;
      charA = '我';
      decimalA = 100;
      doubleA = 3.14;
      floatA = (float)3.14;
      intA = 99;
      longA = 10000000000000000;
      sbyteA = 125;
      shortA = 6666;
      uintA = 200;
      ulongA = 20000000000000000;
      ushortA = 300;
    }
    // 显示
    public void Display()
    {
      Console.WriteLine("boolA: {0}", boolA);
      Console.WriteLine("boolB: {0}", boolB);
      Console.WriteLine("byteA: {0}", byteA);
      Console.WriteLine("charA: {0}", charA);
      Console.WriteLine("decimalA: {0}", decimalA);
      Console.WriteLine("doubleA: {0}", doubleA);
      Console.WriteLine("floatA: {0}", floatA);
      Console.WriteLine("intA: {0}", intA);
      Console.WriteLine("longA: {0}", longA);
      Console.WriteLine("sbyteA: {0}", sbyteA);
      Console.WriteLine("shortA: {0}", shortA);
      Console.WriteLine("uintA: {0}", uintA);
      Console.WriteLine("ulongA: {0}", ulongA);
      Console.WriteLine("ushortA: {0}", ushortA);
    }
    // 存储尺寸
    public void Size()
    {
      Console.WriteLine("Size of bool: {0}", sizeof(bool));
      Console.WriteLine("Size of byte: {0}", sizeof(byte));
      Console.WriteLine("Size of char: {0}", sizeof(char));
      Console.WriteLine("Size of decimal: {0}", sizeof(decimal));
      Console.WriteLine("Size of double: {0}", sizeof(double));
      Console.WriteLine("Size of float: {0}", sizeof(float));
      Console.WriteLine("Size of int: {0}", sizeof(int));
      Console.WriteLine("Size of long: {0}", sizeof(long));
      Console.WriteLine("Size of sbyte: {0}", sizeof(sbyte));
      Console.WriteLine("Size of short: {0}", sizeof(short));
      Console.WriteLine("Size of uint: {0}", sizeof(uint));
      Console.WriteLine("Size of ulong: {0}", sizeof(ulong));
      Console.WriteLine("Size of ushort: {0}", sizeof(ushort));
    }
  }
}