using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Practice
{
    internal class Amstrong
    {
        //An Armstrong number of three digits is an integer
        //such that the sum of the cubes of its digits
        //is equal to the number itself.
        static void Main3(string[] args)
        {
            Console.Write("Enter a Number to Check Whether it is Amstrong or not");
            int num=Convert.ToInt32(Console.ReadLine());
            int temp = num;
            int r, sum = 0;
            
          
            while (num > 0)
            {

                r = num % 10;
                sum = sum + (r * r * r);
                num = num / 10;

            }
            if (temp==sum)
            {
                Console.WriteLine("is amstrong");
            }
            else
                Console.WriteLine("not a Amstrong");

            Console.ReadLine();
        }
    }
}
