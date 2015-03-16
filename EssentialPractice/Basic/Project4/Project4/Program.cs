///<simmary>
/// Diffrent Literals
/// Created By Dhruvesh Akhani
/// Created On 16-07-2014
/// </summary>
using System;
class literalsdemo
{
    public static void Main(String[] args)
    {
       
        unchecked//c# Compiler Ignore Type Boundray Value,Defaut Mode is Checked ,Only Examine For Integer Expression
        {
            byte b = 10;
            int no = 12;
            int no2 = 0xa;
            long area =100;
            float Weight = 4.0f;
            // byte c = 266; Not Converted To Byte Range Is More
            Console.WriteLine(b);
            Console.WriteLine(no);
            Console.WriteLine(no2);
            Console.WriteLine(area);
            long n = 200000L * 200000L;
            Console.WriteLine(n);
            long c = 210000*210000;//That Gives Truncate Or Garbage Value
            Console.WriteLine(c);
            Console.WriteLine(Weight);
            char i='A';
            int ascii = (int)i;
            Console.WriteLine(ascii);
            Console.WriteLine(i);
            char j = '\u0266';
            Console.WriteLine(j);
           
            bool engineer = true;
            Console.WriteLine("I am Student"+ engineer);
           
        }

    }

    

}