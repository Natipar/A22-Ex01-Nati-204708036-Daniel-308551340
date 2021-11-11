using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            string binary1,binary2,binary3,binary4;
            bool validationFlag = true;
            System.Console.WriteLine("Hello, please enter 4 binary numbers, 8 bit sized each");
            binary1 = System.Console.ReadLine();
            binary2 = System.Console.ReadLine();
            binary3 = System.Console.ReadLine();
            binary4 = System.Console.ReadLine();
            while (validationFlag)
            {
                
            }
            System.Console.WriteLine(temp);
        }
        public static int BinaryToDecimal(string BinNum)
        {
            int NumberInDecimal =0;
            for(int i = 0; i<BinNum.Length; i++)
            {
                if (BinNum[i] == '1')
                NumberInDecimal += (int)Math.Pow(2, BinNum.Length-i-1);
            }
            return NumberInDecimal;
        }
        private static bool isInputValid(string i_binNumber)
        {
            if (i_binNumber.Length != 8) return false;
            if ((!(i_binNumber.Contains("1")))&& (!(i_binNumber.Contains("0")))) return false;
            return true;
        }
    }
}
