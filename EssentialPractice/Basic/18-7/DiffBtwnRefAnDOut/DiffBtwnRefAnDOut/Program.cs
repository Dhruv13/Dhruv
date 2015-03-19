using System;
public class Xyz
{
    static void one(out int n)
    {
        n = 0;
        Console.WriteLine(n);
    }
    static void two(ref int n)
    {
        ++n;
        Console.WriteLine(n);
        ++n;
    }
    static void Main()
    {
        int a = 10;
       one(out a);
        two(ref a);
        Console.WriteLine(a);
    }
}