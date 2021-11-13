using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Offset = # of spaces before starts
// StarCount = Amount of stars on the top row
// Increment = Change the amount of spaces and stars


namespace A22_Ex01_2
{
    class Program
    {
        public static void Main()
        {
            HourGlass(0,5,2); // No spaces before the * on the first line, 5 stars in the line
            System.Console.WriteLine("Done!");
        }

        public static void HourGlass(int i_Offset, int i_StarCount, int i_Increment)
        {
            if(i_Offset < 0 && i_Increment < 0)
            {
                return;
            }

            for(int i = 0; i < i_Offset; i+=2) // Amount of spaces before the *
            {
                System.Console.Write(" ");
            }

            for(int i = 0; i < i_StarCount; i++) // Amount of stars
            {
                System.Console.Write("*");
            }
            System.Console.WriteLine(""); // Go down a line - if we want spaces between the lines, add \n

            if (i_StarCount == 1)
            {
                i_Increment = -2; // So we will have odd number of starts in each line
            }

            HourGlass(i_Offset + i_Increment, i_StarCount- i_Increment, i_Increment);
        }
    }
}
