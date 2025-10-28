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
            int A = int.Parse(sr.ReadLine());
            int B = int.Parse(sr.ReadLine());

            sw.WriteLine(A * B);

            sw.Flush();
            sw.Close();
            sr.Close();
        }
    }
}