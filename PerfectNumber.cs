using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    public static class PerfectNumber
    {
        public static void CheckPerfectNumber()
        {
            Console.WriteLine("starting range of Number");
            int min = int.Parse(Console.ReadLine());
            Console.WriteLine("ending range of number");
            int max = int.Parse(Console.ReadLine());
            Console.WriteLine("the perfect number in given range:");
            int n, i, sum;

            for (n = min; n <= max; n++)
            {
                i = 1;
                sum = 0;
                while (i < n)
                {
                    if (n % i == 0)
                        sum = sum + i;
                    i++;

                }
                if (sum == n)
                    Console.Write(" " + n);

            }
        }
    }
}