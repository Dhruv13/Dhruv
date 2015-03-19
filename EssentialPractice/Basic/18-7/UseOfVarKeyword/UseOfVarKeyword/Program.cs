using System;
// the var keyword is used to create local variables or block leval variables
//compile time check
class Varcheck
{
    public static void Main(String[] args)
    {
        var name = "Dhruvesh Akhani";
        for(int i=1;i<=10;i++)
        {
            Console.WriteLine("Welcome to the C#");
        }
        Console.WriteLine(name);
    }
}