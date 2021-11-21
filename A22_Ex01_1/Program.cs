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
            string switchItem;
            int convertedInput;
            do
            {
                System.Console.WriteLine(@"Hello User, please choose the service you'd like to use :
1. Binary numbers
2. Constant HourGlass
3. Smart HourGlass
4. String
5. Zubin Meta
Enter 0 to exit the menu");
                switchItem = System.Console.ReadLine();
                if (Int32.TryParse(switchItem, out convertedInput))
                {
                    switch (convertedInput)
                    {
                        case 1:
                            Ex01_1();
                            break;
                        case 2:
                            A22_Ex01_2.Program.Ex01_2();
                            break;
                        case 3:
                            A22_Ex01_3.Program.Ex01_3();
                            break;
                        case 4:
                            A22_Ex01_4.Program.Ex01_4();
                            break;
                        case 5:
                            A22_Ex01_5.Program.Ex01_5();
                            break;
                    }
                }
            } while (convertedInput != 0);
        }

        public static void Ex01_1()
        {
            string[] binaryArray = new string[4];
            int ascendingAmount = 0;

            for (int i = 0; i < binaryArray.Length; i++)
            {
                System.Console.WriteLine("Hello, please enter 1 binary number, 8 bit sized");
                binaryArray[i] = System.Console.ReadLine();
                while (!IsInputValid(binaryArray[i]))
                {
                    System.Console.WriteLine("Binary number isn't valid, please enter a valid one: ");
                    binaryArray[i] = System.Console.ReadLine();
                }
            }

            double zeroCounter = AverageNumberOfZeros(binaryArray);
            double oneCounter = averageNumberOfOnes(binaryArray);
            int[] decimalArray = BinaryToDecimal(binaryArray);

            System.Console.Write("The numbers in decimal are :");
            foreach (int number in decimalArray)
            {
                System.Console.Write(number + ", ");
                if (IsAscending(number.ToString()))
                {
                    ascendingAmount++;
                }
            }

            System.Console.WriteLine("\nThe average number of zeros is : {0} and the average number of ones is : {1}", zeroCounter, oneCounter);
            int powerCounter = PowerOfTwoAmount(decimalArray);

            System.Console.WriteLine("There are {0} numbers that are a power of 2", powerCounter);
            System.Console.WriteLine("There are {0} numbers which are in ascending order", ascendingAmount);
            double maxNum = decimalArray.Max();
            double minNum = decimalArray.Min();
            System.Console.WriteLine("The max number is {0}, and the min number is {1}", maxNum, minNum);
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
            foreach (string number in i_BinaryNumbers)
            {
                foreach (char binaryNumberChar in number)
                {
                    if (binaryNumberChar == '0')
                    {
                        zeroCounter++;
                    }
                }
            }

            return zeroCounter / i_BinaryNumbers.Length;
        }

        public static double averageNumberOfOnes(string[] i_BinaryNumbers)
        {
            double oneCounter = 0;
            foreach (string number in i_BinaryNumbers)
            {
                foreach (char binaryNumberChar in number)
                {
                    if (binaryNumberChar == '1')
                    {
                        oneCounter++;
                    }
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
