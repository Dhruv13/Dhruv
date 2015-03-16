/// <summary>
/// Program : Use Of Datetime Format
/// Created By Dhruvesh Akhani
/// Created On 16-7-2014
/// </summary>
using System;
class FormatDateTimeDemo
{
    public static void Main(String[] args)
    {
        DateTime dt = DateTime.Now;
        Console.WriteLine(dt.ToString("d"));//Date
        Console.WriteLine(dt.ToString("dd"));//Month in number
        Console.WriteLine(dt.ToString("ddd"));//Dayname Half
        Console.WriteLine(dt.ToString("dddd"));//Dayname Full
        Console.WriteLine(dt.ToString("M"));// july 16
        Console.WriteLine(dt.ToString("MM"));//07
        Console.WriteLine(dt.ToString("D"));// full informaton
        Console.WriteLine(dt.ToString("DD"));// only shows DD i.e not usable
        Console.WriteLine(dt.ToString("MMM"));//jul
        Console.WriteLine(dt.ToString("MMMM"));//July
        Console.WriteLine(dt.ToString("m"));// same as'M'
        Console.WriteLine(dt.ToString("mm"));//  value shows minutes
        Console.WriteLine(dt.ToString("y"));//July 2014
        Console.WriteLine(dt.ToString("Y"));// same as capital Y
        Console.WriteLine(dt.ToString("yy"));//14
        Console.WriteLine(dt.ToString("yyy"));//2014
        Console.WriteLine(dt.ToString("yyyy"));// same as three yyy Answer
        Console.WriteLine(dt.ToString("YY"));// only YY
        Console.WriteLine(dt.ToString("hh"));
        Console.WriteLine(dt.ToString("ss"));
        Console.WriteLine(dt.ToString("t"));//1:04 AM
        Console.WriteLine(dt.ToString("tt"));//AM
        Console.WriteLine(dt.ToString("dd-MM-yy hh:mm:ss"));

    }

}