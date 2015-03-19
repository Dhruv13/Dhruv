using System;
class ArrayDemo
{
   static void Main()
    {
        int[] a = new int[5];
        a[0] = 9;
        Console.WriteLine(a.Length+" "+a[0]);
        float[] b;
        b = new float[7];
        Console.WriteLine(b.Length);

       string[] c = { "ajay", "vijay", "Ravindra" };
       foreach (string x in c)
       {
           Console.WriteLine(x);
       }

       int[] t = new int[5] { 10, 15, 16,78,56 };// only 5 element is valid 
       {
           foreach(int r in t)
           {
               Console.WriteLine(r);
           }
       }
       Console.WriteLine();

       int[] q = new int[] { 10, 15, 16, 78, 56 };//limit is not defined in declaration
       {
           foreach (int r in q)
           {
               Console.WriteLine(r);
           }
       }

        //Console.WriteLine(c.Length);
            
                

       
        

    }
}