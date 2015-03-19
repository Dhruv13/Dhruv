using System;

public class Test
{
    public static int a;
    public int b;
    public static float c;
    public float d;
    public static double e;
    public double f;
    public static DateTime g;
    public DateTime h;
    public static decimal i;
    public decimal j;
    public static bool k;
    public bool m;
    public static char n;
    public char o;
    public string p;
    public static string q;

}
public class AnotherDemo
{
    public static void Main(string[] args)
    {
        //float a;
        Console.WriteLine(Test.a);
        Test no1 = new Test();
        Console.WriteLine(no1.b);
        Console.WriteLine(Test.c);
        Console.WriteLine(no1.d);
        Console.WriteLine(Test.e);
        Console.WriteLine(no1.f);
        Console.WriteLine(Test.g);
        Console.WriteLine(no1.h);
        Console.WriteLine(Test.i);
        Console.WriteLine(no1.j);
        Console.WriteLine(Test.k);
        Console.WriteLine(no1.m);
        Console.WriteLine(Test.n);
        Console.WriteLine(no1.o);
        Console.WriteLine(Test.q);
        Console.WriteLine(no1.p);
        Test.a = 52;
        no1.b = 59;
        Test.g = DateTime.Parse("11/11/2014");
        no1.h = DateTime.Parse("11/11/2014");
        Console.WriteLine(Test.a+" "+no1.b+""+Test.g+""+no1.h);

    }
}