using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 1
// 1 2
// 1 2 3
// 1 2 3 4
// 1 2 3 4 5 

namespace PatternPrograms
{
    class PatternHalfPyramidOfNumbers
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the size : ");
            int n = Convert.ToInt32(Console.ReadLine());

            for(int i=1; i<=n; i++)
            {
                for(int j=1;j<=i;j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine("");
            }
        }
    }
}
