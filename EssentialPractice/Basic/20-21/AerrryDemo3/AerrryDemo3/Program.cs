using System;
class AryDemo
{
    static void Main()
    {
        int[,] a = new int[5,5];
        for (int i = 0; i <= a.GetUpperBound(1); i++)
        {
            for (int j = 0; i < a.GetUpperBound(1); i++)
            {
                Console.WriteLine("" + a[i,j]);
            }
        }
    }


}