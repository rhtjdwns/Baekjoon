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
            string num = Console.ReadLine();
            string[] sp = num.Split();
            int N, M;
            int[,] arrayA, arrayB;

            N = int.Parse(sp[0]);
            M = int.Parse(sp[1]);

            arrayA = new int[N, M];
            arrayB = new int[N, M];

            for (int i = 0; i < N; ++i)
            {
                num = Console.ReadLine();
                sp = num.Split();
                for (int j = 0; j < M; ++j)
                {
                    arrayA[i, j] = int.Parse(sp[j]);
                }
            }

            for (int i = 0; i < N; ++i)
            {
                num = Console.ReadLine();
                sp = num.Split();
                for (int j = 0; j < M; ++j)
                {
                    arrayB[i, j] = int.Parse(sp[j]);
                }
            }

            for (int i = 0; i < N; ++i)
            {
                for (int j = 0; j < M; ++j)
                {
                    Console.Write(arrayA[i, j] + arrayB[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}