using System;
// Demo of Tuple
public class Test
{
    public static Tuple<int,int> Divide(int divided,int divisor)
    {
        int result = divided / divisor;
        int reminder = divided % divisor;
        return Tuple.Create<int, int>(result, reminder);

    }
    static void Main()
    {
        Tuple<int, int> no = new Tuple<int, int>(10, 20);
        Console.WriteLine(no.Item1+""+no.Item2);
        Tuple<int, int> result = Divide(17, 5);
        Console.WriteLine(result.Item1 + "\n" + result.Item2);
        Tuple<int, string, int>[] bdate =
        {
            
            new Tuple<int,string,int>(22,"Sept",1958),
            new Tuple<int,string,int>(2,"Dec",1966),
            new Tuple<int,string,int>(18,"Aug",1994),
            new Tuple<int,string,int>(26,"Oct",2000),
            new Tuple<int,string,int>(14,"Sept",1994)
            
                                   };
        foreach(var a in bdate)
        {
            Console.WriteLine(a.Item1 + "\n" + a.Item2 + "\n" + a.Item3);
        }
    }
 

}