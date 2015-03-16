///<summary>
/// Use Of String 
///Created By Dhruvesh Akhani
///Created On 16-07-2014

///</summary>
using System;
class Stringdemo
{
    public static void Main(String[] args)
    {

        String path1 = "C:\\indows\\java\\est";
        Console.WriteLine(path1);
        // ForwardSlash Demo
        String path = "C:/Windows/ProgramFiles/c#Language/Programs/test";
        Console.WriteLine(path);
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("@ Verbatin Demo");
        Console.WriteLine();
        string info = @"hi!!!!!!!!!    date is 7/15/2014
                       Whats Up???
                        
                                                How are you????
                            Thank for everything to me";
        Console.WriteLine(info);
        // We Can Also Use String Concatination Operation For This Kind Of Printing Purpose
        info = "My" + "\t" + "Self" + "Dhruv" + "\n\t\tThakkar";
        Console.WriteLine(info);
    }
}