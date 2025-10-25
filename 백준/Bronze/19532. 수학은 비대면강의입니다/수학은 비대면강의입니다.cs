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
            int[] ints = new int[6];
            double x = 0, y = 0;

            string[] st = sr.ReadLine().Split();
            for (int i = 0; i < ints.Length; i++)
            {
                ints[i] = int.Parse(st[i]);
            }

            for (int i = -999; i <= 999; ++i)
            {
                for (int j = -999; j <= 999; ++j)
                {
                    if ((ints[0] * i + ints[1] * j == ints[2]) && (ints[3] * i + ints[4] * j == ints[5]))
                    {
                        sw.Write($"{i} {j}");
                    }
                }
            }

            sw.Flush();
            sw.Close();
            sr.Close();
        }
    }
}