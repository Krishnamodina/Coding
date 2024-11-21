using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class quetient_Remainder
    {
        static void Main9(string[]args)
        {
            int num, div, rem, quo = 0;
            Console.Write("Enter Number :");
            num=int.Parse(Console.ReadLine());
            Console.Write("Enter divider :");
            div=int.Parse(Console.ReadLine());
            if (num > div)
            {
                while (num >= div)
                {
                    num = num - div;
                    quo++;
                }
                rem = num;
                Console.WriteLine("quotient is :" + quo+" Remainder :"+rem);
            }
            else
                Console.WriteLine("Enter valid input");

            Console.ReadLine();
        }
    }
}
