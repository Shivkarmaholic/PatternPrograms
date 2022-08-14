using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//*****
//****
//***
//**
//*

namespace PatternPrograms
{
    class PatternInvertedHalfPyramid
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size : ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = n;i>0;i--)
            {
                for(int j=i;j>0;j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }

    }
}
