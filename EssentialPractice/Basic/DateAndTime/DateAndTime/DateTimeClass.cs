/*
 * This program is created by Dhruvesh akhani.
 * This program(s) are created for practicing purpose.
 * any one can use this program(s) to learn the c# by themselves.
 * any one can change or modify the content of the program(s).
 * we do not give the behaviour of progrm(s) whether it is changed by any one.
*/
using System;
class DateTimeDemo
{
    public static void Main(string[] args)
    {
        DateTime dt = DateTime.Now;
        Console.WriteLine(dt);
        dt = DateTime.UtcNow;
        Console.WriteLine(dt);
        String str="11/4/2004";
            dt=DateTime.Parse(str);// parsing in DateTime in datatype
            Console.WriteLine(str);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            DateTime birthdate = DateTime.Parse("8/18/1994 4:30:00 PM");
            Console.WriteLine(birthdate.Date);
            Console.WriteLine(birthdate.Day);
            Console.WriteLine(birthdate.Year);
            Console.WriteLine(birthdate);
            dt = dt.AddDays(65);// If I Write .Now ThenAfter days will be added to currentDateTime

            Console.WriteLine(dt);
        

    }
}