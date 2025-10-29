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
            while (true)
            {
                string[] st = sr.ReadLine().Split();

                int a = int.Parse(st[0]);
                int b = int.Parse(st[1]);
                int c = int.Parse(st[2]);

                if (a == 0 && b == 0 && c == 0) break;

                if (a >= b + c || b >= a + c || c >= b + a)
                {
                    sw.WriteLine("Invalid");
                    continue;
                }

                if (a == b && b == c && c == a)
                {
                    sw.WriteLine("Equilateral");
                }
                else if (a == c || b == c || a == b)
                {
                    sw.WriteLine("Isosceles");
                }
                else if (a != b && b != c && c != a)
                {
                    sw.WriteLine("Scalene");
                }
            }

            sw.Flush();
            sw.Close();
            sr.Close();
        }
    }
}