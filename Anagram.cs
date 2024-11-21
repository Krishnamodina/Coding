using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class Anagram
    {
       static void Main6(string[]args)
       {
            string s1, s2;
            Console.Write("Enter string1 :");
            s1= Console.ReadLine();
            Console.Write("Enter string1 :");
            s2 = Console.ReadLine();
            char[] char1= s1.ToLower().ToCharArray();
            char[] char2= s2.ToLower().ToCharArray();
            Array.Sort(char1);
            Array.Sort(char2);  
            string str1=new string(char1);
            string str2=new string(char2);
            if (str1 == str2)
            {
                Console.Write(" anagram");
            }
            else
            {
                Console.Write("not anagram");
            }
            Console.ReadLine();
       }
    }
}
