using System;
/// <summary>
/// Program: Use String.Format 
/// </summary>
class StringDemo
{
    static int Main()
    {
        int a = 10, b = 20;
        string str = string.Format("a is{0}\nand b is {1}\nso mul is {2}\n", a, b, a * b);
        Console.WriteLine(str);
       


        string abc = str.ToUpper ();
        Console.WriteLine();
        Console.WriteLine(abc);
        Console.WriteLine(str.Length);
        string first = "hi";
        string second = "How are you?";
        string third = "hi";
        string four = "I am fine";
        string sum= first + second;

        
        Console.WriteLine(sum);
        Console.WriteLine(first + "\tequals\t" + second + "\t-->" + first.Equals(second));
        Console.WriteLine(first + "\tequals\t" + third + "\t\t-->" + first.Equals(third));
        Console.WriteLine(first + "\tequals\t" + four + "\t-->" + first.Equals(four));
        Console.WriteLine(third + "\tequals\t" + second + "\t-->" + third.Equals(second));
        
        

        return 0;
;    }

}