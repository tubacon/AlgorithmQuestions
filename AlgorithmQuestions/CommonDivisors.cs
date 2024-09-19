using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmQuestions
{
    public static class CommonDivisors
    {
        public static void RunCommonDivisors()
        {
            List<int> divisors = new List<int>();

            Console.WriteLine("Enter a value : ");
            int val1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a value : ");
            int val2 = int.Parse(Console.ReadLine());

            int min = Math.Min(val1, val2);

            for (int i = 1; i <= min; i++)
            {
                if (val1 % i == 0 && val2 % i == 0)
                {
                    divisors.Add(i);
                }
            }
        }
    }
}
