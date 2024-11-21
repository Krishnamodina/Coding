using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Practice
{
    internal class Program
    {

        static void Main1(string[] args)
        {
            //for fibonacci series
            int n1 = 0, n2 = 1,n3;

            Console.Write("Enter a Number : ");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int row = 1; row < num; row++)
            {
                n1 = 0; n2 = 1;

                Console.Write(n2+" ");
                   
                for (int col = 1; col <row; col++)
                {
                    n3 = n1 + n2;
                    Console.Write(n3+" ");
                    n1 = n2;
                    n2 = n3;
                }
               
                Console.WriteLine();
            }
            Console.ReadLine();
//1
//1 1
//1 1 2
//1 1 2 3
//1 1 2 3 5
//1 1 2 3 5 8
//1 1 2 3 5 8 13
//1 1 2 3 5 8 13 21




        }


    }
}
















//namespace Practice
//{
//    internal class Program
//    {

//        static void Main(string[] args)
//        {


//            Console.Write("Enter a Number : ");
//            int num = Convert.ToInt32(Console.ReadLine());

//            for (int row = 0; row < num; row++)
//            {
//                int totalColsInRow = row > num ? 2 * num - row : row;
//                     int noOfSpaces = num - totalColsInRow;

//                for (int s = 0; s < noOfSpaces; s++)
//                {
//                    Console.Write(" ");
//                }
//                for (int col = row; col >=1; col--)
//                {
//                    Console.Write(col);
//                }
//                for (int col = 2; col <= row; col++)
//                {
//                    Console.Write(col);
//                }
//                Console.WriteLine();
//            }
//            Console.ReadLine();

//         1
//        212
//       32123
//      4321234
//     543212345
//    65432123456
//   7654321234567
//  876543212345678
// 98765432123456789




//        }


//    }
//}




//static void Main(string[] args)
//{


//    Console.Write("Enter a Number : ");
//    int num = Convert.ToInt32(Console.ReadLine());

//    for (int row = 0; row < 2 * num; row++) {
//        int totalColsInRow = row > num ? 2 * num - row : row;
//        int noOfSpaces = num - totalColsInRow;
//        for (int s = 0; s < noOfSpaces; s++)
//        {
//            Console.Write(" ");
//        }
//        for (int col = 0; col < totalColsInRow ; col++)
//        {
//            Console.Write(" *");
//        }
//        Console.WriteLine();
//    }
//    Console.ReadLine();          


//    //Diomand pattern


//}










//static void Main(string[] args)
//{


//    Console.Write("Enter a Number : ");
//    int num = Convert.ToInt32(Console.ReadLine());
//    int c;
//    for (int r = 1; r <= num * 2; r++)
//    {
//        int k = r > num ? num * 2 - r : r;

//        int space= num-k;
//        for (int s = 0; s < space; s++)

//        {
//            Console.Write(
//                " ");

//        }
//        for (c = 1; c <= k; c++)

//        {
//            Console.Write(
//                "*");

//        }
//        Console.WriteLine();

//    }
//    Console.ReadLine();
//          *
//         **
//        ***
//       ****
//      *****
//     ******
//    *******
//   ********
//  *********
// **********
//  *********
//   ********
//    *******
//     ******
//      *****
//       ****
//        ***
//         **
//          *





//}




//        static void Main(string[] args)
//        {


//            Console.Write("Enter a Number : ");
//            int num = Convert.ToInt32(Console.ReadLine());
//            int c;
//            for (int r = 1; r <= num*2; r++)
//            {
//                int k=r>num ? num*2-r : r;


//                for ( c = 1; c <= k; c++)

//                {
//                    Console.Write(
//                        "*");

//                }
//                Console.WriteLine();

//            }
//            Console.ReadLine();
//*
//**
//***
//****
//*****
//****
//***
//**
//*

//        }


//static void Main(string[] args)
//{


//    Console.Write("Enter a Number : ");
//    int num = Convert.ToInt32(Console.ReadLine());

//    for (int r = 1; r <= num; r++)
//    {



//        for (int c = 1; c <=r; c++)

//        {
//            Console.Write(c);

//        }
//        Console.WriteLine();

//    }
//    Console.ReadLine(); 
//    1
//    12
//    123
//    1234
//    12345
//}










//static void Main(string[] args)
//{
//    Console.Write("Enter a Number : ");
//    int num = Convert.ToInt32(Console.ReadLine());

//    for (int r = 1; r <= num; r++)
//    {



//        for (int c = num; c >= 1 + r - 1; c--)
//        {
//            Console.Write("*");

//        }
//        Console.WriteLine();

//        *****
//        ****
//        ***
//        **   
//        *
//    }

//    Console.ReadLine();


//}
//static void Main(string[] args)
//{
//    Console.Write("Enter a Number : ");
//    int num = Convert.ToInt32(Console.ReadLine());

//    for (int r = 1; r <= num; r++)
//    {
//        for (int c = 1; c <= r; c++)
//        {
//            Console.Write("*");
//        }
//        Console.WriteLine();

//    }
//    Console.ReadLine();
//}

//*
//**
//***
//****
//*****

