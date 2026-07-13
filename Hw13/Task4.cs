using System;
using System.Linq;

namespace Hw13
{
    internal class Task4
    {
        static int SumDigits(int number)
        {
            int sum = 0;

            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }

            return sum;
        }

        static void Main()
        {
            int[] numbers = { 121, 75, 81, 56, 19 };

            Console.WriteLine("За зростанням:");

            var asc = from n in numbers
                      orderby SumDigits(n)
                      select n;

            foreach (var n in asc)
                Console.Write(n + " ");

            Console.WriteLine();

            Console.WriteLine("За спаданням:");

            var desc = from n in numbers
                       orderby SumDigits(n) descending
                       select n;

            foreach (var n in desc)
                Console.Write(n + " ");

            Console.ReadKey();
        }
    }
}
