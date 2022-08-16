using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternPrograms
{
    class SwappingWithoutThirdVariable
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers : ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine(a);
            Console.WriteLine(b);

        }

    }
}
