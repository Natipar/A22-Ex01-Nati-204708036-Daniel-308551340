using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A22_Ex01_4;

namespace A22_Ex01_1
{
    public class Program
    {
        public static void Main()
        {
            //Ex01_1();
            A22_Ex01_4.Program.Ex01_4();
        }
        public static void Ex01_1()
        {
            string[] binary_array = new string[4];
            int[] decimal_array = new int[4];
            double one_counter=0, zero_counter=0, Min_num, Max_num;
            int power_counter = 0, ascending_amount = 0;
            for (int i = 0; i < binary_array.Length; i++)
            {
                System.Console.WriteLine("Hello, please enter 1 binary number, 8 bit sized");
                binary_array[i] = System.Console.ReadLine();
                while (!(isInputValid(binary_array[i])))
                {
                    System.Console.WriteLine("Binary number isnt valid, please enter a valid one: ");
                    binary_array[i] = System.Console.ReadLine();
                }
            }
            zero_counter = averageNumberOfZeros(binary_array);
            one_counter = averageNumberOfOnes(binary_array);
            decimal_array = BinaryToDecimal(binary_array);
            System.Console.Write("The numbers in decimal are :");
            for (int i =0; i<decimal_array.Length; i++)
            {
                System.Console.Write(decimal_array[i] + ", ");
                if (isAscending(decimal_array[i].ToString())) ascending_amount++;
            }
            System.Console.WriteLine("\nThe average number of zeros is : {0} and the average number of ones is : {1}", zero_counter,one_counter);
            power_counter = powerOfTwoAmount(decimal_array);
            System.Console.WriteLine("There are {0} numbers that are a power of 2", power_counter);
            System.Console.WriteLine("There are {0} numbers which are in ascending order",ascending_amount);
            Max_num = decimal_array.Max();
            Min_num = decimal_array.Min();
            System.Console.WriteLine("The max number is {0}, and the min number is {1}", Max_num, Min_num);
        }
        public static bool isAscending (string decimal_num)
        {
            if (decimal_num.Length == 1)
                return true;
            int last = int.Parse(decimal_num.Last().ToString());
            int prev = int.Parse(decimal_num[decimal_num.Length - 2].ToString());

            return last > prev && isAscending(decimal_num.Substring(0, decimal_num.Length - 1));
        }
    
        public static int powerOfTwoAmount(int[] decimal_array)
        {
            int power_counter = 0;
            for (int i = 0; i<decimal_array.Length; i++)
            {
                if ((int)(Math.Ceiling((Math.Log(decimal_array[i]) / Math.Log(2))))
               == (int)(Math.Floor(((Math.Log(decimal_array[i]) / Math.Log(2)))))) power_counter++;
            }
            return power_counter;
        }
        public static int[] BinaryToDecimal(string[] BinNum)
        {
            int NumberInDecimal = 0;
            int[] decimal_array = new int[4];
            for(int i = 0; i<BinNum.Length; i++)
            {
                for(int j =0; j < BinNum[i].Length; j++)
                {
                    if (BinNum[i][j] == '1')
                        NumberInDecimal += (int)Math.Pow(2, BinNum[i].Length - j - 1);
                }
                decimal_array[i] = NumberInDecimal;
                NumberInDecimal = 0;
            }
            return decimal_array;
        }
        public static double averageNumberOfZeros(string[] binary_numbers)
        {
            double zero_counter = 0;
            for (int i =0; i < binary_numbers.Length; i++)
            {
                for(int j =0; j< binary_numbers[i].Length; j++)
                {
                    if (binary_numbers[i][j] == '0') zero_counter++;
                }
            }
            return zero_counter/binary_numbers.Length;
        }
        public static double averageNumberOfOnes(string[] binary_numbers)
        {
            double one_counter = 0;
            for (int i = 0; i < binary_numbers.Length; i++)
            {
                for (int j = 0; j < binary_numbers[i].Length; j++)
                {
                    if (binary_numbers[i][j] == '1') one_counter++;
                }
            }
            return one_counter/binary_numbers.Length;
        }
        public static bool isInputValid(string i_binNumber)
        {
            if (i_binNumber.Length != 8) return false;
            foreach (char c in i_binNumber)
                if (c != '0' && c != '1')
                    return false;
            return true;
        }
    }
}

