﻿
using System;

namespace MyConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, };
            PrintNumber("Numbers",Numbers);
            PrintNumber("EvenNumbers",Numbers.Where(x =>IsEvenNumber(x)));
            PrintNumber("Numbers",Numbers.Where(x =>IsOddNumber(x)));
            Console.ReadKey();
        }

       static void PrintNumber(string Title, IEnumerable<int> Numbers)
        {
            Console.WriteLine();   
            Console.Write($"{Title} :[");
            foreach( int i in Numbers ) { 
               
                 Console.Write( $" {i}" );
            
            }

              Console.Write("]");
            Console.WriteLine();

        }
        static bool IsEvenNumber(int Numbers)
        {
            if( Numbers % 2 == 0 ) { return true; }
            else return false;  
        }

        static bool IsOddNumber(int Numbers)
        {
            if (Numbers % 2 != 0) { return true; }
            else return false;
        }

    }
}