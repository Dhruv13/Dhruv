//User can set value or ref during program execution
using System;
class DynamicDemo
{
    public static void Main(String[] args)
    {
        dynamic a;
        //no need to initialize
        a = "Hello World";
        Console.WriteLine(a);
        a = 15.6f;
        Console.WriteLine(a);
    }
}