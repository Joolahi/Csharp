using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4_Palindrome
{
    internal class Program
    {
        static bool CheckPalindrome(string givenSentence)
        {
            int lenght = givenSentence.Length;
            for (int i = 0; i < lenght / 2; i++)
            {
                if (givenSentence[i] == givenSentence[lenght - i - 1])
                {
                    return true;
                }
            }    
            return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Give word or sentence: ");
            string sentence = Console.ReadLine();

            if (CheckPalindrome(sentence))
            {
                Console.WriteLine($"{sentence} is palindrome.");
            }
            else
            {
                Console.WriteLine($"{sentence} is not palindrome.");
            }
          
        }
    }
}
