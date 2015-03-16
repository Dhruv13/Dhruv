using System;
/// <summary>
/// Program   : Which One is Fast String ya StringBuilder??
/// Created By: Dhruvesh Akhani
/// Created On: 16-06-2014
/// </summary>
class StringBuilderDemo
{
    public static void Main(String[] args)
    {
        string str = " ";
        System.Diagnostics.Stopwatch watch = new System.Diagnostics.Stopwatch();
       // System.Text.StringBuilder sb = new System.Text.StringBuilder();
        watch.Start();
        {
            for(int i=1;i<100000;i++)
            {
                str = str + i;
                //sb.Append(i);

            }
            watch.Stop();
            Console.WriteLine("Total time:" + watch.ElapsedMilliseconds + "ms");
        }
    }
}