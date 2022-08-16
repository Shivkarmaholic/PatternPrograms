using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternPrograms
{
    class FactorialUsingRecursion
    {
        public static int fact(int n)
        {
            if(n == 1)
                return 1;
            return(n*fact(n-1));             

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number to find Factorial");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Factorial = "+ fact(num));
        }
    }
}
