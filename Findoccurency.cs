using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class Findoccurency
    {
        static void Main8(string[] args)
        {
            //Console.Write("Enter a string :");
            //string str= Console.ReadLine();
            //Dictionary <char,int> dict = new Dictionary<char,int>();
            //foreach (var character in str)
            //{
            //    if (character != 32)
            //    {
            //        if (!dict.ContainsKey(character))
            //        {
            //            dict.Add(character, 1);
            //        }
            //        else
            //            dict[character]++;
            //    }

            //}
            //foreach (var character in dict)
            //{
            //    Console.WriteLine("{0},{1}",character.Key,character.Value);
            //}
            //Console.ReadLine();


            //Console.Write("Enter a string: ");
            //string str = Console.ReadLine();

            //int[] charCount = new int[256]; // Assuming ASCII characters

            //foreach (char c in str)
            //{
            //    // Increment the count for the ASCII value of the character
            //    charCount[c]++;
            //}

            //// Print character frequency
            //Console.WriteLine("Character Frequency:");
            //for (int i = 0; i < charCount.Length; i++)
            //{
            //    if (charCount[i] > 0 && !char.IsWhiteSpace((char)i))
            //    {
            //        Console.WriteLine($"{(char)i}: {charCount[i]}");
            //    }
            //}



            int []arr = { 1,2 ,2,30,30,40,50,40,60,7,9,8,7};
            Dictionary<int,int> dict= new Dictionary<int,int>();    
            foreach(int i in arr)
            {
                if(dict.ContainsKey(i))
                {
                    dict[i]++;
                }
                else
                    dict[i] = 1;    
                
            }
            foreach(var pai in dict)
            {
                Console.WriteLine("{0}={1} time(s)",pai.Key,pai.Value);
            }

            Console.ReadLine();
            
        }
    }
}
