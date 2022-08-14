using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//          *
//        * * *
//      * * * * *
//    * * * * * * *
//  * * * * * * * * *

namespace PatternPrograms
{
    class PatternFullPyramid
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int j=0;
            for(int i = 1; i <=n; i++,j=0)
            {
                for(int spaces = n-i; spaces > 0; spaces--)
                {
                    Console.Write(" ");
                }
                while (j < 2*i-1)
                {
                    Console.Write("*");
                    j++;
                }
                Console.WriteLine("");
            }
        }
    }
}
