using System;
class Test
{
    static void check(out int a,int b)
    {
        a = 100;
        b = 200;

    }
    static void Main()
    {
        int a = 1, b = 2;
        check(out a,b);
        Console.WriteLine(a + "   " + b);

    }
}