using System;

namespace conditional_operators_ternary_operator_
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            a = 10;
            b = (a == 1) ? 20 : 30;
            Console.WriteLine("value of b is "+b);

            b = (a == 10) ? 20 : 30;
            Console.WriteLine("value of b is " + b);

            Console.ReadKey();
        }
    }
}
