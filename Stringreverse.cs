using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class Stringreverse
    {
        static void Main2(string[] args)
        {
            string str, reversestring=string.Empty;
            Console.Write("Enter a String: ");
            str = Console.ReadLine();   
            str=str.ToLower();
            for(int i=str.Length-1;i>=0;i--)
            {
                reversestring = reversestring + str[i];
            }
            Console.Write("Reversed String is :"+reversestring);
            Console.WriteLine();
            if(str==reversestring)
            { Console.WriteLine("Palindrome"); }
            else { Console.WriteLine("not a palindrom"); }
            Console.ReadLine();
        }
    }
}
