using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternPrograms
{
    class PalindromeSentence
    {
        public static bool isPalindrome(string str)
        {
            string st = "";
            int x = 0;
            
            foreach (char c in str.ToLower())     
                if(char.IsLetter(c)!=char.IsDigit(c))
                    st=st+c;

            char[] chararr=st.ToCharArray();
            Array.Reverse(chararr);

            string rev=new string(chararr);                   

            if (st == rev)
            {
                return true;
            }
            else return false;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a String : ");
            string str = Console.ReadLine();

            if(isPalindrome(str))
            {
                Console.WriteLine("The sentence is Palindrome");
            }
            else
                Console.WriteLine("Sentence is Not Palindrome!!!!");
        }
    }
}
