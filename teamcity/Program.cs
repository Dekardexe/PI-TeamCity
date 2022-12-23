using System;
using System.Numerics;

namespace teamcity
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(tripleFactorial(15));
        }

        public static BigInteger tripleFactorial(int a)
        {
            var factorial = new BigInteger(1);
            for (int i = 1; i <= a; i++)
            {
                factorial *= i;
            }
            factorial *= 3;
            return factorial;

            Console.WriteLine("Factorial *3 =");
            Console.Write(factorial) ;
        }

        
    }
}
