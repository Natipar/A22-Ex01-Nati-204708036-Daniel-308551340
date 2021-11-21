using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A22_Ex01_4;

namespace A22_Ex01_5
{
    public class Program
    {
        public static void Main()
        {
        }

        public static void Ex01_5()
        {
            System.Console.WriteLine("please enter a number with 7 digits : ");
            string inputItem = System.Console.ReadLine();
            while (!IsInputValid(inputItem))
            {
                System.Console.WriteLine("Sorry, the number you've enter doesn't meet the requirements.try again : ");
                inputItem = Console.ReadLine();
            }

            System.Console.WriteLine(IsInputValid(inputItem));
            System.Console.WriteLine("The max value digit in the number is : {0}", MaxDigitInNumber(inputItem));
            System.Console.WriteLine("The average of the digits value is : {0}", AverageOfDigits(inputItem));
            System.Console.WriteLine("{0} digits in your number can be divided by 3", CountDivisionsByThree(inputItem));
            System.Console.WriteLine("{0} digits are smaller than the unity digit", CountSmallerDigits(inputItem));
        }

        public static int CountSmallerDigits(string i_Str)
        {
            int biggerDigitsCounter = 0;
            char firstDigit = i_Str[0];
            foreach (char c in i_Str)
            {
                if (c < firstDigit)
                {
                    biggerDigitsCounter++;
                }
            }

            return biggerDigitsCounter;
        }

        public static int CountDivisionsByThree(string i_Str)
        {
            int divisionsCounter = 0;
            foreach (char c in i_Str)
            {
                int currentDigit = c - '0';
                if (currentDigit % 3 == 0)
                {
                    divisionsCounter++;
                }
            }

            return divisionsCounter;
        }

        public static int MaxDigitInNumber(string i_Str)
        {
            int max = i_Str.Max();
            return max - '0';
        }

        public static double AverageOfDigits(string i_Str)
        {
            double average = 0;
            foreach (char c in i_Str)
            {
                int currentDigit = c - '0';
                average += currentDigit;
            }

            average /= i_Str.Length;
            return average;
        }

        public static bool IsInputValid(string i_Str)
        {
            if (i_Str.Length != 7)
            {
                return false;
            }

            if (!A22_Ex01_4.Program.IsAllDigits(i_Str))
            {
                return false;
            }

            return true;
        }
    }
}
