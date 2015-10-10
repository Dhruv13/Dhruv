using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// use of yield keyword
public class Prime : IEnumerable<int>
{
    private int start, end;
    public Prime(int start, int end)
    {
        this.start = start;
        this.end = end;
    }
    IEnumerator<int> IEnumerable<int>.GetEnumerator()
    {
        for (int n = start; n <= end; n++)
        {
            bool isPrime = true;
            for (int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime) yield return n;
        }
    }


    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        throw new NotImplementedException();
    }
}
class Hello
{
    static void Main()
    {
        Prime p = new Prime(10, 1000);
        foreach (var i in p)
        {
            Console.WriteLine(i);
        }
    }
}
