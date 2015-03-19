using System;

    class ArrayDemo2
    {
        public static void Main(String[] args)
        {
            int[] a=new int[5];
            Console.WriteLine(a.Rank);
            double[,] c = new double[5,4];
            Console.WriteLine(c.Rank);
            Console.WriteLine(c.Length);
            

        }
    }
