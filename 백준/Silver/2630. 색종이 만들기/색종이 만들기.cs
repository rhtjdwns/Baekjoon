using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Project2
{
    internal class main
    {
        public static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
        public static StreamReader sr = new StreamReader(Console.OpenStandardInput());

        public static void Divide(int x, int y, int size, int[,] paper, ref int white, ref int blue)
        {
            int first = paper[x, y];
            bool isSame = true;

            for (int i = x; i < x + size; ++i)
            {
                for (int j = y; j < y + size; ++j)
                {
                    if (paper[i, j] != first)
                    {
                        isSame = false;
                        break;
                    }
                }

                if (!isSame) break;
            }

            if (isSame)
            {
                if (first == 0) white++;
                else blue++;
                return;
            }

            int newSize = size / 2;
            Divide(x, y, newSize, paper, ref white, ref blue);
            Divide(x, y + newSize, newSize, paper, ref white, ref blue);
            Divide(x + newSize, y, newSize, paper, ref white, ref blue);
            Divide(x + newSize, y + newSize, newSize, paper, ref white, ref blue);
        }

        public static void Main(string[] args)
        {
            int[,] paper;
            int white = 0;
            int blue = 0;

            int N = int.Parse(sr.ReadLine());
            paper = new int[N + 1, N + 1];

            for (int i = 0; i < N; i++)
            {
                string[] st = sr.ReadLine().Split();
                
                for (int j = 0; j < st.Length; j++)
                {
                    paper[i, j] = int.Parse(st[j]);
                }
            }

            Divide(0, 0, N, paper, ref white, ref blue);

            sw.WriteLine(white);
            sw.WriteLine(blue);

            sw.Flush();
            sw.Close();
            sr.Close();
        }
    }
}