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

        public static void Divide(int x, int y, int size, int[,] tree)
        {
            int first = tree[x, y];
            bool isSame = true;

            for (int i = x; i < x + size; ++i)
            {
                for (int j = y; j < y + size; ++j)
                {
                    if (tree[i, j] != first)
                    {
                        isSame = false;
                        break;
                    }
                }

                if (!isSame) break;
            }

            if (isSame)
            {
                sw.Write($"{first}");
                return;
            }

            sw.Write("(");
            int newSize = size / 2;
            Divide(x, y, newSize, tree);
            Divide(x, y + newSize, newSize, tree);
            Divide(x + newSize, y, newSize, tree);
            Divide(x + newSize, y + newSize, newSize, tree);
            sw.Write(")");
        }

        public static void Main(string[] args)
        {
            int[,] tree;

            int N = int.Parse(sr.ReadLine());
            tree = new int[N + 1, N + 1];

            for (int i = 0; i < N; i++)
            {
                string st = sr.ReadLine();
                
                for (int j = 0; j < st.Length; j++)
                {
                    tree[i, j] = (int)(st[j] - '0');
                }
            }

            Divide(0, 0, N, tree);

            sw.Flush();
            sw.Close();
            sr.Close();
        }
    }
}