
using System;
/// <summary>
/// Program: Use Of String Class As Well As Use Of StringBuilder Class 
/// Created By: Dhruvesh Akhani
/// Created On: 16-06-2014
/// </summary>
class immutable
{
    public static void Main(String[] args)
    {
        String name="Dhruv";// an Obj Is Created To Store Dhruv
        name=name+"Akhani";// New Obj Is Created To Store DhruvAkhani
        Console.WriteLine(name);// new Obj is Assigned EveryTime
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        //System.Text.StringBuilder
        // This class is Faster
        System.Text.StringBuilder sb = new System.Text.StringBuilder();// On a Same Obj Updation Is Possible
        sb.Append("Thank You");
        sb.Append("Very Much");
        sb.Append("Best");
        Console.WriteLine(sb);

    }

}