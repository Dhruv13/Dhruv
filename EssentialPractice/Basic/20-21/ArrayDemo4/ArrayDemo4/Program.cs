using System;
class AerryDemo
{
    public static void Main(String[] args)
    {
        int[] a = new int[5];
        int[,] b = new int[3, 4];
        int[, ,] c = new int[2, 2, 2];
        int[] e = new int[3] { 44, 55, 66 };
        int[,] d = { { 20, 30, 40 }, { 10, 20, 30 } };
        double[, ,] f = { { { 19, 29, 39 }, { 49, 59, 79 }, { 89, 99, 109 } } };
        foreach (int x in a) 
        {
            Console.Write(x);
            Console.WriteLine();
        }
        Console.WriteLine();
        foreach (int x in b)
        {
            Console.Write(x);
            Console.WriteLine();
        }
        Console.WriteLine();
        foreach (int x in c)
        {
            Console.Write(x);
            Console.WriteLine();
        }

        Console.WriteLine();
        foreach (int x in d)
        {
            Console.Write(x);
            Console.WriteLine();
        }
        Console.WriteLine();
        foreach (int x in e)
        {
            Console.Write(x);
            Console.WriteLine();
        } 
        Console.WriteLine();
        foreach (int x in f)
        {
            Console.Write(x);
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}