using System;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class Primenumber
    {
        static void Main(string[] args)
        {
            //Console.Write("Enter the limit :");
            //int lim=int.Parse(Console.ReadLine());
            //for(int i=2;i<lim;i++)//dividend
            //{
            //    bool isPrime = true;
            //    for(int j=2;j<i;j++)//divider
            //    {
            //        if(i%j==0)
            //        {
            //            isPrime = false;
            //            break;
            //        }

            //    }
            //    if (isPrime == true)
            //    {
            //        Console.WriteLine("{0}", i);
            //    }
            //}

            //Console.Write("Enter the limit :");
            //int lim=int.Parse(Console.ReadLine());
            //for(int i=1;i<=lim ;i++)
            //{
            //    //for spaces
            //   for(int j=i;j<lim;j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int h=1;h<=i*2-1;h++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine(" ");
            //}


            //Console.ReadLine();
            //Console.Write("Enter the lim :");
            ////int a = 0, b = 1, c;
            ///
            //int rows = 10;
            //for (int i = 0; i < rows; i++)
            //{
            //    int a = 0, b = 1;
            //    if (i <= 5)
            //    {
            //        for (int j = 0; j <= i; j++)
            //        {
            //            int temp = a + b;
            //            Console.Write(temp);
            //            a = b; b = temp;
            //        }
            //    }
            //    else
            //    {
            //        for (int j = i; j >= 0; j--)
            //        {
            //            Console.Write(" ");
            //        }
            //    }

            //    Console.WriteLine();

            //

            //}
            int r = 10,k=0,a=0,b=1,c ;  
           for(int i=1;i<=r;i++)
            {
                if (i <= 5)
                    k++;
                else 
                    k--;


                c = a + b;
                Console.Write(c + " ");
                a = b; b = c;
                for (int j = 1; j <= 5; j++)

                {
                    if (j <= k-1)
                    {
                        Console.Write(" ");
                    }



                    else
                    {
                        
                       
                    }
                }
               
                Console.WriteLine();
            }    

            Console.ReadLine();
        }
    }
}


