using System;
using System.IO;

namespace Recursion
{
    public class Factorial
    {
        private const int Base = 0;

        public int Calculate(int number)
        {
            if (number < Base) throw new InvalidDataException("Only positive numbers are accepted");
            if (number == Base) return 1;
            
            return number * Calculate(number - 1);
        }

        public static void Test(int input = 10)
        {
            var factorial = new Factorial();
            var result = factorial.Calculate(input);
            
            Console.WriteLine($"Factorial of {input} = {result}");
        }
    }
}