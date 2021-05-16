******* Palindrom.CS ************ 

Code :

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meddiff_Prog
{
    public class Palindrome
    {
        public static bool IsPalindrome(string str)
        {
            int min = 0; 
            int max = str.Length - 1;
            while (true)
            {
                if (min > max)
                {
                    Console.WriteLine("Is a palindrome");
                    return true;
                }
                char a = str[min];
                char b = str[max];

                // Scan forward for a while invalid.
                while (!char.IsLetterOrDigit(a))
                {
                    min++;
                    if (min > max)
                    {
                        Console.WriteLine("Is a palindrome");
                        return true;
                    }
                    a = str[min];
                }

                // Scan backward for b while invalid.
                while (!char.IsLetterOrDigit(b))
                {
                    max--;
                    if (min > max)
                    {
                        Console.WriteLine("Is a palindrome");
                        return true;
                    }
                    b = str[max];
                }

                if (char.ToLower(a) != char.ToLower(b))
                {
                    Console.WriteLine("Not a palindrome");
                    return false;
                }
                min++;
                max--;
            }
        }

        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public static string ReverseWords(string sentence)
        {
            string[] words = sentence.Split(' ');
            Array.Reverse(words);
            return string.Join(" ", words);
        }

        public static void Main(string[] args)
        {
            Console.Write("Enter string to be tested: ");
            IsPalindrome(Console.ReadLine());
            Console.Write("Press any key...");
            Console.ReadKey();

        }
    }
}
 
