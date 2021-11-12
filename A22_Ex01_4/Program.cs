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

        }
        public static void Ex01_4()
        {
            string s = null;
            bool validiation_flag = true;
            while (validiation_flag) 
            { 
                System.Console.WriteLine("Please enter a word contains only numbers or letters");
                s = System.Console.ReadLine();
                if (isInputValid(s)) validiation_flag = false;
            }
            //System.Console.WriteLine(isInputValid(s));
            int numeric_value;
            if (Int32.TryParse(s, out numeric_value)){
                if (numeric_value%4 == 0)
                    System.Console.WriteLine("The number can be divided by 4");
            }
            //System.Console.WriteLine("{0}, {1}, {2}", isAllDigits(s),isAllLetters(s),isInputValid(s));
            if (isAllLetters(s))  
                System.Console.WriteLine("The number of uppercase letters in your word is : {0}"
                    ,UppercaseLettersCount(s));
            //System.Console.WriteLine(numeric_value);
        }
        public static int UppercaseLettersCount(string i_str)
        {
            int letters_count = 0;
            for (int i = 0; i < i_str.Length; i++)
            {
                if (char.IsUpper(i_str[i])) letters_count++;
            }
            return letters_count;
        }
        public static bool isInputValid(string i_s)
        {
            if (i_s.Length == 0) return false;
            if (!isAllDigits(i_s) & !isAllLetters(i_s)) return false;
            return true;
        }
        public static bool isAllLetters(string i_s)
        {
            foreach (char c in i_s) { if (!Char.IsLetter(c)) return false; }
            return true;
        }
        public static bool isAllDigits(string i_s)
        {
            foreach (char c in i_s) { if (!Char.IsDigit(c)) return false; }
            return true;
        }
    }
}
