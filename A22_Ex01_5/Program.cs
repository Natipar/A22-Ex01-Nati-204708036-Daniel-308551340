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

        public static void Ex05()
        {
            string input_item;
            System.Console.WriteLine("please enter a number with 7 digits : ");
            input_item = System.Console.ReadLine();
            while (!isInputValid(input_item))
            {
                System.Console.WriteLine("Sorry, the number you've enter doesnt meet the requirements.try again : ");
                input_item = Console.ReadLine();
            }
            System.Console.WriteLine(isInputValid(input_item));
            System.Console.WriteLine("The max value digit in the number is : {0}",maxDigitInNumber(input_item));
            System.Console.WriteLine("The average of the digits value is : {0}", averageOfDigits(input_item));
            System.Console.WriteLine("{0} digits in your number can be divided by 3",countDivisionsByThree(input_item));
            System.Console.WriteLine("{0} digits are smaller than the unity digit", countSmallerDigits(input_item));
        }

        public static int countSmallerDigits(string i_str)
        {
            int biggerDigitsCounter = 0;
            char firstDigit = i_str[0];
            foreach (char c in i_str)
            {
                if (c < firstDigit) biggerDigitsCounter++;
            }

            return biggerDigitsCounter;
        }
        public static int countDivisionsByThree(string i_str)
        {
            int divisons_counter = 0, currentDigit;
            foreach (char c in i_str)
            {
                currentDigit = c - '0';
                if (currentDigit % 3 == 0) divisons_counter++;
            }

            return divisons_counter;

        }
        public static int maxDigitInNumber(string i_str)
        {   
            int max = i_str.Max();
            return max - '0';
        }

        public static double averageOfDigits(string i_str)
        {
            int currentDigit = 0;
            double average = 0;
            foreach (char c in i_str)
            {
                currentDigit = c - '0';
                average += currentDigit;
            }

            average = average / i_str.Length;
            return average;
        }
        public static bool isInputValid(string i_str)
        {
            if (i_str.Length != 7) return false;
            if (!(A22_Ex01_4.Program.isAllDigits(i_str))) return false;
            //if (i_str[0] != 0) return false;
            return true;
        }
    }
}
