using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A22_Ex01_3
{
    public class Program
    {
        public static void Main()
        {
            Ex01_3();
        }

        public static void Ex01_3()
        {
            Console.WriteLine("Please enter the height of the hourglass (and then press enter): ");
            string hourGlassHeightString = Console.ReadLine();


            if (int.TryParse(hourGlassHeightString, out int hourGlassHeight))
            {
                A22_Ex01_2.Program.Ex01_2(0, 2, hourGlassHeight);
            }
            else
            {
                Console.WriteLine("The input is not valid");
            }

            // TODO: Handle bad input
        }
    }
}
