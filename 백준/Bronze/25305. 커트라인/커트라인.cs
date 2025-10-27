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
            string[] st = sr.ReadLine().Split();
            int N = int.Parse(st[0]);
            int k = int.Parse(st[1]);
            int[] arr = new int[N];

            st = sr.ReadLine().Split();
            for (int i = 0; i < N; i++)
            {
                arr[i] = int.Parse(st[i]);
            }

            arr = arr.OrderByDescending(x => x).ToArray();
            sw.WriteLine(arr[k - 1]);

            sw.Flush();
            sw.Close();
            sr.Close();
        }
    }
}