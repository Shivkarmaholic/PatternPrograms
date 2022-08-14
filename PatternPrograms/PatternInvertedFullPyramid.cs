using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

     //*********
     // *******
     //  *****
     //   ***
     //    *

namespace PatternPrograms
{
    class PatternInvertedFullPyramid
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size : ");
            int rows = Convert.ToInt32(Console.ReadLine());
            int k=0,count=0;
            for(int i = rows; i >0; i--,k=0)
            {
                for(int spaces=i;spaces<rows;spaces++)
                {
                    Console.Write(" ");
                }
                while (k!=i*2-1)
                {
                                   
                    Console.Write("*");
                    k++;
                }
                Console.WriteLine("");
            }
        }
    }
}
