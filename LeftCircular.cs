using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class LeftCircular
    {
        static void Main4(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5 };
            int rotations = 2; // Number of rotations

            // Perform left circular rotation
            for (int r = 0; r < rotations; r++)
            {
                int firstElement = arr[0];
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    arr[i] = arr[i + 1];
                }
                arr[arr.Length - 1] = firstElement;
            }

            // Print the rotated array
            foreach (int n in arr)
            {
                Console.Write(n + " ");
            }
            Console.ReadLine();
        }

        //static void Main(string[] args)
        //{
        //    int[] arr = new int[] { 1, 2, 3, 4, 5 };
        //    int size=arr.Length;
        //    int temp;
        //    for(int i=size-1;i>0;i--)
        //    {
        //        temp = arr[size-1];
        //        arr[arr.Length - 1] = arr[i-1];
        //        arr[i-1]=temp; 
        //    }
        //    foreach(int n in arr)
        //    {
        //        Console.Write(n+"");
        //    }
        //    Console.ReadLine();
        //}
    }
}
