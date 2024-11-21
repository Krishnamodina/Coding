using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class Substring
    {
      static void Main(string[] args)
      {
            string str;
            Console.Write("Enter String :");
            str = Console.ReadLine();
            for(int i=0;i<str.Length;i++)
            { 
                StringBuilder sb = new StringBuilder();

                for (int j = i; j < str.Length; j++)
                {
                    sb.Append(str[j]);
                    Console.Write(sb + " ");
                }
            }
            Console.ReadLine();
      }
    }
}
