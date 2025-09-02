using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Project1
{
    class Program
    {
        public static void Main(string[] args)
        {
            int N, count = 0;
            int num = 2;
            int result = 0;

            N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; ++i)
            {
                if (count == 0) count += 1;
                else count += count;

                num += count;
            }

            Console.WriteLine(num * num);
        }
    }
}