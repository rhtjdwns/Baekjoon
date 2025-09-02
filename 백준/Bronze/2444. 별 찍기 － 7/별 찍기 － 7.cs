using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project1
{
    class Program
    {
        public static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; ++i)
            {
                for (int j = 1; j <= num - i - 1; ++j)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j <= (2 * i); ++j)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            for (int i = num - 2; i >= 0; --i)
            {
                for (int j = 1; j <= num - i - 1; ++j)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j <= (2 * i); ++j)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}