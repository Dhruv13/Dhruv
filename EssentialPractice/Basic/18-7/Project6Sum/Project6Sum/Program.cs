using System;
namespace hello
{
    class SumDemo
    {
        public static void Main(String[] args)
        {
            int no1 = 10, no2 = 20;
            String str = "Addition of " + no1 + "and" + no2 + "is" + (10 + 20) + "\tok.";
            Console.WriteLine(str);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            // String Formatmethod
            // {0} is always first peremeter and associated with first value .{1} is always second and so on
            str = String.Format("i am {0} and My college is{1}", "dhruv", "Nice");
            Console.WriteLine(str);
            int a = 15, b = 12;
            str = String.Format("Subtraction of{1} from {0} is{2}", a, b, a - b);
            Console.WriteLine(str);
            str = String.Format("Addition Of{0}and {1} is{2}", a, b, a + b);
            Console.WriteLine(str);
            str = string.Format("multiplication of{0}{0}{0}is {1}", a, a * a * a);
            Console.WriteLine(str);

        }
    }
}