/// <summary>
/// Determine The Range Of Simple Types
/// Created By Dhruevsh Akhani
/// Created On 16-7-2014
/// </summary>
using System;
class check
{
    public static void Main(String[] args)
    {
        Console.WriteLine(int.  MinValue  +"      " + int.MaxValue);
        Console.WriteLine(byte. MinValue +"       " + byte.MaxValue);
        Console.WriteLine(float.MinValue+"        " + float.MaxValue);
        Console.WriteLine(long. MinValue +"       " + long.MaxValue);
        int no = 006;
        String str = no.ToString();
        Console.WriteLine(str);
        Console.WriteLine(no.ToString ("N"));
        Console.WriteLine(no.ToString ("c"));
        Console.WriteLine(no.ToString ("c3"));
        //N stands for number and C or c stand for currency
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        str = "10";
        int n = int.Parse(str);// we can also use float,double etc for parsing
        Console.WriteLine(n);
        //str = "14za"; invalid string data can throws an Exeption
        //int b = int.Parse(str);
        //Console.WriteLine(b);
                
    }
}
