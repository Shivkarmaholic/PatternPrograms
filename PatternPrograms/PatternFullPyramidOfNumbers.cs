using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//          1
//        2 3 2
//      3 4 5 4 3
//    4 5 6 7 6 5 4
//  5 6 7 8 9 8 7 6 5

namespace PatternPrograms
{
    class PatternFullPyramidOfNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size : ");
            int rows = Convert.ToInt32(Console.ReadLine());
            int space = 0, count = 0, k = 0, count1 = 0;

            for (int i = 1; i <= rows; ++i)
            {
                for (space = 1; space <= rows - i; ++space)
                {
                    Console.Write(" ");
                    ++count;
                }
                while (k != 2 * i - 1)
                {
                     if (count <= rows - 1)
                    {
                        Console.Write(i + k);
                        ++count;
                    }
                    else
                    {
                        ++count1;
                        Console.Write(i + k - 2 * count1);

                    }
                    ++k;
                }
                count1 = count = k = 0;
                Console.WriteLine("");
            }


        }

    }
}