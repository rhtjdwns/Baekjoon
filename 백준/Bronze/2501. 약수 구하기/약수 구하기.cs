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
            int K = int.Parse(st[1]);
            int count = 0;
            bool isComplete = false;

            for (int i = 1; i <= N; i++)
            {
                int cul = N % i;
                if (cul == 0) count++;
                if (count == K)
                {
                    sw.WriteLine(i);
                    isComplete = true;
                    break;
                }
            }

            if (!isComplete)
            {
                sw.WriteLine("0");
            }

            sw.Flush();
            sw.Close();
            sr.Close();
        }
    }
}