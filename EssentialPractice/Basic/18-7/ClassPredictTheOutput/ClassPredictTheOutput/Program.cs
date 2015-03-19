using System;
public class Testing
{
    public int no1;
   // public int no2;
    
    

}
public class Other
{
    static void Main()
    {
        Testing a = new Testing();
        Testing b = a;
        a.no1 = 10;
        b.no1 = 20;
        Console.WriteLine(a.no1 + "" + b.no1);
    }
}