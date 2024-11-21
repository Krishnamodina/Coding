using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class REachWorf
    {
        static void Main8(string[]args)
        {
            int cout = 0;
            Console.Write("Enter a string: ");
            string str=Console.ReadLine();  
            Console.WriteLine("Your Entered String is:"+str);
            Console.WriteLine("String After Reverse");
            char[] chars = str.ToCharArray();   
            for(int i=chars.Length-1;i>-0;i--)
            {
                if (chars[i] !=32)
                {
                    cout++;
                }
                else if (chars[i]==32)
                {
                    for(int j=i+1;cout>0;j++, cout--)
                    {
                        Console.Write(chars[j]);
                    }
                    Console.Write(" ");
                }
            }
            for(int j=0;j<=cout;j++)
            {
                Console.Write(chars[j]);
            }
            Console.ReadLine();
        }
    }
}
