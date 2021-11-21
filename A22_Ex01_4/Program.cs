using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A22_Ex01_4
{
    public class Program
    {
        public static void Main()
        {
            Ex01_4();
        }

        public static void Ex01_4()
        {
            string s = null;
            bool validationFlag = true;
            while (validationFlag)
            {
                Console.WriteLine("Please enter a word contains only numbers or letters");
                s = Console.ReadLine();
                if (IsInputValid(s))
                {
                    validationFlag = false;
                }
            }

            if (int.TryParse(s, out int numericValue))
            {
                if (numericValue % 4 == 0)
                {
                    Console.WriteLine("The number can be divided by 4");
                }
            }

            if (IsAllLetters(s))
            {
                Console.WriteLine("The number of uppercase letters in your word is : {0}", UppercaseLettersCount(s));
            }

            if (IsPalindrome(s))
            {
                Console.WriteLine("The string is a palindrome! cool!");
            }
        }

        public static bool IsPalRec(
            string i_Str,
            int i_S,
            int i_)
        {
            if (i_S == i_)
            {
                return true;
            }

            if (i_Str[i_S] != i_Str[i_])
            {
                return false;
            }

            if (i_S < i_ + 1)
            {
                return IsPalRec(i_Str, i_S + 1, i_ - 1);
            }

            return true;
        }

        public static bool IsPalindrome(string i_Str)
        {
            int n = i_Str.Length;
            return n == 0 || IsPalRec(i_Str, 0, n - 1);
        }

        public static int UppercaseLettersCount(string i_Str)
        {
            int lettersCount = 0;
            foreach (char c in i_Str)
            {
                if (char.IsUpper(c))
                {
                    lettersCount++;
                }
            }

            return lettersCount;
        }

        public static bool IsInputValid(string i_S)
        {
            if (i_S.Length == 0)
            {
                return false;
            }

            if (!IsAllDigits(i_S) & !IsAllLetters(i_S))
            {
                return false;
            }

            return true;
        }

        public static bool IsAllLetters(string i_S)
        {
            foreach (char c in i_S)
            {
                if (!char.IsLetter(c))
                {
                    return false;
                }
            }

            return true;
        }

        public static bool IsAllDigits(string i_S)
        {
            foreach (char c in i_S)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
