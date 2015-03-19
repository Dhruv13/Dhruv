using System;
class check
{
    public static void Main(String[] args)
    {
        string str = "ajay";
        int no;
        if (int.TryParse(str, out no))
            Console.WriteLine("sucess:" + no);
       // else
         //   Console.WriteLine("Failed");
        var str1="01/07/2014 10:40:15 PM";
        DateTime dt;
        if (DateTime.TryParse(str1, out dt))
            Console.WriteLine("sucess" + dt);
        var bt1 = "14.5f";
        int i=0;
        if (int.TryParse(bt1, out i))
            Console.WriteLine("sucess" + i);
        else
            Console.WriteLine("sorry wrong syntax");

    }
}