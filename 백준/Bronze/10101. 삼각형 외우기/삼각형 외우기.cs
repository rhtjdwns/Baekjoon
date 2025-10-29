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
            int[] arr = new int[3];
            for (int i = 0; i < arr.Length; ++i)
            {
                arr[i] = int.Parse(sr.ReadLine());
            }

            if (arr[0] == 60 && arr[0] == arr[1] && arr[1] == arr[2])
            {
                sw.WriteLine("Equilateral");
            }
            else if (arr[0] + arr[1] + arr[2] == 180 && (arr[0] == arr[1] || arr[1] == arr[2] || arr[2] == arr[0]))
            {
                sw.WriteLine("Isosceles");
            }
            else if (arr[0] + arr[1] + arr[2] == 180)
            {
                sw.WriteLine("Scalene");
            }
            else
            {
                sw.WriteLine("Error");
            }

            sw.Flush();
            sw.Close();
            sr.Close();
        }
    }
}