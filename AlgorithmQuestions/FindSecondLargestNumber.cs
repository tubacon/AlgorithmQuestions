using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmQuestions
{
    public static class FindSecondLargestNumber
    {
        public static void RunFindSecondLargestNumber()
        {
            //Finding the Second Largest Number in the Sequence

            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8 };

            int largest = 0;
            int secondLargest = 0;

            foreach (int num in arr)
            {
                if (num > largest)
                {
                    secondLargest = largest;
                    largest = num;
                }
                else if (num > secondLargest && num < largest)
                {
                    secondLargest = num;
                }
            }

            Console.WriteLine("Second largest number is " + secondLargest);
        }
    }
}
