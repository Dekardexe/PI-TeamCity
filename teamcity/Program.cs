using System;
using System.Numerics;

namespace teamcity
{
    class Program
    {
        sta void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            tripleFactorial(5);
        }

        static void tripleFactorial(int a)
        {
            var factorial = new BigInteger(1);
            for (int i = 1; i <= a; i++)
            {
                factorial *= i;
            }
            factorial *= 3;
            Console.WriteLine("Factorial *3 =");
            Console.Write(factorial) ;
        }

        
    }
}
