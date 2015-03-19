using System;
class demo
{
    static void Main()
    {
        int[] check = { 10, 14, -98, 44 };
        Array.Sort(check);
        foreach (int i in check)
        
            Console.WriteLine(i);
            Console.WriteLine();
        
        int[] Rev = { 14, 17, 15 , -87 };
        Array.Reverse(Rev);
        foreach (int c in Rev)
        
            
            Console.WriteLine(c);
            Console.WriteLine();
        
        int[] arr = {1,9,19,24,54};
        Array.Sort(arr);
        //Array.BinarySearch(arr, 9);
        
        Console.WriteLine(Array.BinarySearch(arr, 19));
        //foreach (int c in arr)
        //    Console.WriteLine(c + "SUCESS SEARCH");

    }
    
}