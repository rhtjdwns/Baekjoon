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
            int[] ints = new int[5];
            int sum = 0;

            for (int i = 0; i < ints.Length; i++)
            {
                string st = sr.ReadLine();
                ints[i] = int.Parse(st);
                sum += ints[i];
            }

            ints = ints.OrderBy(x => x).ToArray();

            sw.WriteLine(sum / 5);
            sw.WriteLine(ints[2]);

            sw.Flush();
            sw.Close();
            sr.Close();
        }
    }
}