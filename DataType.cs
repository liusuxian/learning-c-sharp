using System;

namespace DataTypeNamespace
{
  public class DataType
  {
    // 布尔值，True 或 False，默认 False
    private bool boolValA;
    private bool boolValB;
    // 8 位无符号整数，0 到 255，默认 0
    private byte byteVal;
    // 16 位 Unicode 字符，U +0000 到 U +ffff，默认 '\0'
    private char charVal;
    // 128 位精确的十进制值，28-29 有效位数，(-7.9 x 1028 到 7.9 x 1028) / 100 到 28，默认 0.0M
    private decimal decimalVal;
    // 64 位双精度浮点型，(+/-)5.0 x 10-324 到 (+/-)1.7 x 10308，默认 0.0D
    private double doubleVal;
    // 32 位单精度浮点型，-3.4 x 1038 到 + 3.4 x 1038，默认 0.0F
    private float floatVal;
    // 32 位有符号整数类型，-2,147,483,648 到 2,147,483,647，默认 0
    private int intVal;
    // 64 位有符号整数类型，-9,223,372,036,854,775,808 到 9,223,372,036,854,775,807，默认 0L
    private long longVal;
    // 8 位有符号整数类型，-128 到 127，默认 0
    private sbyte sbyteVal;
    // 16 位有符号整数类型，-32,768 到 32,767，默认 0
    private short shortVal;
    // 32 位无符号整数类型，0 到 4,294,967,295，默认 0
    private uint uintVal;
    // 64 位无符号整数类型，0 到 18,446,744,073,709,551,615，默认 0
    private ulong ulongVal;
    // 16 位无符号整数类型，0 到 65,535，默认 0
    private ushort ushortVal;
    // 引用类型，对象（Object）类型
    private object? objVal;
    // 引用类型，动态（Dynamic）类型
    private dynamic? dynamicVal;
    // 引用类型，字符串（String）类型
    private String? strValA;
    private String? strValB;
    private String? strValC;
    private String? strValD;
    private String? strValE;
    // 指针类型
    unsafe private char* cptrVal = null;
    unsafe private int* iptrVal = null;
    // 初始化基础类型数据
    public void InitBaseData()
    {
      boolValA = true;
      boolValB = false;
      byteVal = 96;
      charVal = '我';
      decimalVal = 100;
      doubleVal = 3.14;
      floatVal = (float)3.14;
      intVal = 99;
      longVal = 10000000000000000;
      sbyteVal = 125;
      shortVal = 6666;
      uintVal = 200;
      ulongVal = 20000000000000000;
      ushortVal = 300;
    }
    // 初始化引用类型数据
    public void InitReferenceData()
    {
      objVal = 100; // 装箱
      int value = (int)objVal; // 拆箱
      dynamicVal = "我是中国人1";
      strValA = "我是中国人2";
      strValB = "runoob.com";
      strValC = @"C:\Windows";
      strValD = "C:\\Windows";
      strValE = @"<script type=""text/javascript"">
      <!--
      -->
      </script>";
      Console.WriteLine("InitReferenceData value: {0}", value);
    }
    // 初始化指针类型数据
    public void InitPointerData()
    {
      unsafe
      {
        char c = '中';
        cptrVal = &c;
        Console.WriteLine("cptrVal val: {0} ", *cptrVal);
        Console.WriteLine("cptrVal ptr: 0x{0} ", (int)cptrVal);
        int i = 100;
        iptrVal = &i;
        Console.WriteLine("iptrVal val: {0} ", *iptrVal);
        Console.WriteLine("iptrVal ptr: 0x{0} ", (int)iptrVal);
      }
    }
    // 显示基础类型数据
    public void DisplayBaseData()
    {
      Console.WriteLine("boolValA: {0}", boolValA);
      Console.WriteLine("boolValB: {0}", boolValB);
      Console.WriteLine("byteVal: {0}", byteVal);
      Console.WriteLine("charVal: {0}", charVal);
      Console.WriteLine("decimalVal: {0}", decimalVal);
      Console.WriteLine("doubleVal: {0}", doubleVal);
      Console.WriteLine("floatVal: {0}", floatVal);
      Console.WriteLine("intVal: {0}", intVal);
      Console.WriteLine("longVal: {0}", longVal);
      Console.WriteLine("sbyteVal: {0}", sbyteVal);
      Console.WriteLine("shortVal: {0}", shortVal);
      Console.WriteLine("uintVal: {0}", uintVal);
      Console.WriteLine("ulongVal: {0}", ulongVal);
      Console.WriteLine("ushortVal: {0}", ushortVal);
    }
    // 显示引用类型数据
    public void DisplayReferenceData()
    {
      Console.WriteLine("objVal: {0}", objVal);
      Console.WriteLine("dynamicVal: {0}", dynamicVal);
      Console.WriteLine("strValA: {0}", strValA);
      Console.WriteLine("strValB: {0}", strValB);
      Console.WriteLine("strValC: {0}", strValC);
      Console.WriteLine("strValD: {0}", strValD);
      Console.WriteLine("strValE: {0}", strValE);
    }
    // 显示指针类型数据
    public void DisplayPointerData()
    {
      unsafe
      {
        if (cptrVal != null)
        {
          Console.WriteLine("cptrVal val: {0} ", *cptrVal);
          Console.WriteLine("cptrVal ptr: 0x{0} ", (int)cptrVal);
        }
        if (iptrVal != null)
        {
          Console.WriteLine("iptrVal val: {0} ", *iptrVal);
          Console.WriteLine("iptrVal ptr: 0x{0} ", (int)iptrVal);
        }
      }
    }
    // 基础类型数据存储尺寸
    public void SizeBaseData()
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