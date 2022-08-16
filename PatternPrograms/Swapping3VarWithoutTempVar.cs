using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternPrograms
{
    class Swapping3VarWithoutTempVar
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers : ");

            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            a = a + b + c;
            b = a-(b+c);
            c = a-(b+c);
            a = a-(b+c);

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }
}
