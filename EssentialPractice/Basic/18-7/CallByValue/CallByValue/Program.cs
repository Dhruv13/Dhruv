using System;
public class test
{
    public int no1;

}
public class Mainapp
{
    static void checkvalue(int n)
    {
        n = 90;

    }
    static void Main()
    {
        int a = 1, n = 2;
        checkvalue(a);
        checkvalue(n);
        Console.WriteLine(a + "" + n);
        test t = new test();
        t.no1 = 10;
        checkref(t);
        Console.WriteLine(t.no1);
       

    }
    static void checkref(test y)
    {
        y.no1 = 90;
    }
}