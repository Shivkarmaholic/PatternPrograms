using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//  *
//  **
//  ***
//  ****
//  *****


namespace PatternPrograms
{
    class PatternHalfTriangle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size : ");
            int n = Convert.ToInt32(Console.ReadLine());

            for(int i=0;i<n;i++)
            {
                for(int j=0;j<=i;j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }
    }
}
