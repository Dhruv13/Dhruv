//If You Want To Store Date Diffrence i.e The Use Of TimeSpan
using System;
/// <summary>
/// Program    : Find The Age By The Of TimeSpan
/// Created By : Dhruvesh Akhani
/// Created On :16-07-2014
/// </summary>
class TimeSpan1
{
    public static void Main(String[] args)
    {
        DateTime dt=DateTime.Parse("8/18/1994 04:30:00 PM");
        DateTime nw=DateTime.Now;
      TimeSpan diff = nw-dt;
        Console.WriteLine (diff.TotalDays);
         Console.WriteLine (diff.TotalMinutes);
         Console.WriteLine (diff.Days);
        Double year=0;
            year= (diff.TotalDays/365);
            Console.WriteLine("your Age is" + year);



    }

}