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

        }
        
        public static void Ex01_3()
        {
            System.Console.WriteLine("Please enter the height of the hourglass (and then press enter):");
            string hourGlassHeightString = System.Console.ReadLine();
            int hourGlassHeight;
            if (Int32.TryParse(hourGlassHeightString,out hourGlassHeight)){
                A22_Ex01_2.Program.Ex01_2(0, 2, hourGlassHeight);
            }

            // TODO: Handle bad input

        }

    }
}
