using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A22_Ex01_4;
using A22_Ex01_2;
using A22_Ex01_3;
using A22_Ex01_5;

namespace A22_Ex01_1
{
    public class Program
    {
        public static void Main()
        {
            Ex01_1();
        }

        public static void Ex01_1()
        {
            string[] binaryArray = new string[4];
            int ascendingAmount = 0;

            for (int i = 0; i < binaryArray.Length; i++)
            {
                Console.WriteLine("Hello, please enter 1 binary number, 8 bit sized");
                binaryArray[i] = System.Console.ReadLine();
                while (!IsInputValid(binaryArray[i]))
                {
                    Console.WriteLine("Binary number isn't valid, please enter a valid one: ");
                    binaryArray[i] = Console.ReadLine();
                }
            }

            double zeroCounter = AverageNumberOfZeros(binaryArray);
            double oneCounter = AverageNumberOfOnes(binaryArray);
            int[] decimalArray = BinaryToDecimal(binaryArray);

            Console.Write("The numbers in decimal are :");
            foreach (int number in decimalArray)
            {
                Console.Write(number + ", ");
                if (IsAscending(number.ToString()))
                {
                    ascendingAmount++;
                }
            }

            int powerCounter = PowerOfTwoAmount(decimalArray);
            double maxNum = decimalArray.Max();
            double minNum = decimalArray.Min();
            string msg =
                $@"The average number of zeros is : {zeroCounter} and the average number of ones is : {oneCounter}.
There are {powerCounter} numbers that are a power of 2
There are {ascendingAmount} numbers which are in ascending order
The max number is {maxNum}, and the min number is {minNum}";

            msg = "\n" + msg;
            Console.WriteLine(msg);
        }

        public static bool IsAscending(string i_DecimalNum)
        {
            if (i_DecimalNum.Length == 1)
            {
                return true;
            }

            int last = int.Parse(i_DecimalNum.Last().ToString());
            int prev = int.Parse(i_DecimalNum[i_DecimalNum.Length - 2].ToString());

            return last > prev && IsAscending(i_DecimalNum.Substring(0, i_DecimalNum.Length - 1));
        }

        public static int PowerOfTwoAmount(int[] i_DecimalArray)
        {
            int powerCounter = 0;
            foreach (int number in i_DecimalArray)
            {
                if ((int)Math.Ceiling(Math.Log(number) / Math.Log(2)) == (int)Math.Floor(Math.Log(number) / Math.Log(2)))
                {
                    powerCounter++;
                }
            }

            return powerCounter;
        }

        public static int[] BinaryToDecimal(string[] i_BinNum)
        {
            int numberInDecimal = 0;
            int[] decimalArray = new int[4];
            for (int i = 0; i < i_BinNum.Length; i++)
            {
                for (int j = 0; j < i_BinNum[i].Length; j++)
                {
                    if (i_BinNum[i][j] == '1')
                    {
                        numberInDecimal += (int)Math.Pow(2, i_BinNum[i].Length - j - 1);
                    }
                }

                decimalArray[i] = numberInDecimal;
                numberInDecimal = 0;
            }

            return decimalArray;
        }

        public static double AverageNumberOfZeros(string[] i_BinaryNumbers)
        {
            double zeroCounter = 0;

            StringBuilder binaryCombined = new StringBuilder(i_BinaryNumbers.Length * 8); // multiply by 8 bits
            foreach (string number in i_BinaryNumbers)
            {
                binaryCombined.Append(number);
            }

            for(int i = 0; i < binaryCombined.Length ;i++)
            {
                if(binaryCombined[i] == '0')
                {
                    zeroCounter++;
                }
            }

            return zeroCounter / i_BinaryNumbers.Length;
        }

        public static double AverageNumberOfOnes(string[] i_BinaryNumbers)
        {
            double oneCounter = 0;
            StringBuilder binaryCombined = new StringBuilder(i_BinaryNumbers.Length * 8); // multiply by 8 bits
            foreach (string number in i_BinaryNumbers)
            {
                binaryCombined.Append(number);
            }

            for (int i = 0; i < binaryCombined.Length; i++)
            {
                if (binaryCombined[i] == '0')
                {
                    oneCounter++;
                }
            }

            return oneCounter / i_BinaryNumbers.Length;
        }

        public static bool IsInputValid(string i_BinNumber)
        {
            if (i_BinNumber.Length != 8)
            {
                return false;
            }

            foreach (char c in i_BinNumber)
            {
                if (c != '0' && c != '1')
                {
                    return false;
                }
            }

            return true;
        }
    }
}
