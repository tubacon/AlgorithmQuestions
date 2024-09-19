using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmQuestions
{
    public static class Fibonacci
    {
        //Fibonacci Sequence is a series of numbers obtained by adding each number with the previous number

        public static void RunFibonacci()
        {
            Console.WriteLine("Please enter a count for array.");
            int arrayCount = int.Parse(Console.ReadLine() ?? "0");

            if(arrayCount == 0)
            {
                Console.WriteLine("Incorrect value for array.");
                return;
            }

            int num1 = 1;
            int num2 = 1;
            int num3;

            Console.WriteLine(num1);
            Console.WriteLine(num2);

            //1
            //1
            //2
            //3
            //5
            //8
            //13

            for (int i = 1; i <= arrayCount; i++)
            {
                num3 = num1 + num2;
                num1 = num2;
                num2 = num3; 
                Console.WriteLine(num3);
            }
        }
    }
}
