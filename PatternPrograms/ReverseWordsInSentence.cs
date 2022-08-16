using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternPrograms
{
    class ReverseWordsInSentence
    {
        static void Main(string[] args)
        {
            string str = "My name is Khan";
            string[] s= str.Split(' ');
            string str2="";

            foreach (string s2 in s)
            {
                int count = s2.Length-1;
                while (count>=0)
                {
                    str2 = str2 + s2[count];
                    count--;
                }
                str2 = str2 + " ";

            }
            Console.WriteLine(str2);
        }

    }
}
