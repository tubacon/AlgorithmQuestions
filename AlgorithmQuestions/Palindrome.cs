using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmQuestions
{
    public static class Palindrome
    {
        public static void RunPalindrome()
        {
            //Palindromes are sentences, words and numbers that are the same when read backwards.
            //Ex : civic, level, radar, noon

            Console.WriteLine("Please enter a word for checking palindrome.");
            var val = Console.ReadLine();
            val = val.Replace(" ", "");

            for (int i = 0; i < val.Length / 2; i++)
            {
                if (val[i] != val[val.Length -1 -i])
                {
                    Console.WriteLine("This word is not palindrome.");
                    return;
                }
            }

            Console.WriteLine("This word is palindrome.");
        }
    }
}
