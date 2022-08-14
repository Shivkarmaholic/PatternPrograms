using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1
//2 3
//4 5 6
//7 8 9 10

namespace PatternPrograms
{
    class FloydPattern
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size : ");
            int rows = Convert.ToInt32(Console.ReadLine());
            int num = 1;
            for(int i = 0; i < rows; i++)
            {
                for(int j=0; j < i; j++)
                {
                    Console.Write(" "+num+" ");
                    num++;
                }
                Console.WriteLine("");
            }
        }
    }
}
