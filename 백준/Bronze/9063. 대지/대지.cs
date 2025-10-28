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

        public static void Main(string[] args)
        {
            int N = int.Parse(sr.ReadLine());
            int minX = 10000, maxX = -10000, minY = 10000, maxY = -10000;

            for (int i = 0; i < N; i++)
            {
                string[] st = sr.ReadLine().Split();
                int x = int.Parse(st[0]);
                int y = int.Parse(st[1]);

                if (minX > x)
                {
                    minX = x;
                }
                if (minY > y)
                {
                    minY = y;
                }
                if (maxY < y)
                {
                    maxY = y;
                }
                if (maxX < x)
                {
                    maxX = x;
                }
            }

            sw.WriteLine((maxX - minX) * (maxY - minY));

            sw.Flush();
            sw.Close();
            sr.Close();
        }
    }
}