using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//A
//B B
//C C C
//D D D D
//E E E E E

namespace PatternPrograms
{
    class PatternHalfPyramidOfAlphabets
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size : ");
            int n = 65 + Convert.ToInt32(Console.ReadLine());

            for(int i = 65; i < n; i++)
            {
                for(int j = 65; j <=i; j++)
                {
                    Console.Write(Convert.ToChar(i));
                }
                Console.WriteLine("");
            }
        }
    }
}
