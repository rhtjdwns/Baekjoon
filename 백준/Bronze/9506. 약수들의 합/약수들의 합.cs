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
                string st = Console.ReadLine();

                if (st == "-1") break;

                int a = int.Parse(st);
                int sum = 0;
                
                Queue<int> queue = new Queue<int>();

                for (int i = 1; i * i <= a; i++)
                {
                    if (a % i == 0)
                    {
                        sum += i;
                        queue.Enqueue(i);

                        int j = a / i;
                        if (i != 1 && i != j)
                        {
                            sum += j;
                            queue.Enqueue(j);
                        }
                    }
                }

                if (sum == a)
                {
                    List<int> list = queue.OrderBy(x => x).ToList();

                    sw.Write(a + " = " + list[0]);
                    int size = list.Count;
                    for (int i = 1; i < size; i++)
                    {
                        sw.Write(" + " + list[i]);
                    }
                    sw.WriteLine();
                }
                else
                {
                    sw.WriteLine(a + " is NOT perfect.");
                }
            }

            sw.Flush();
            sw.Close();
            sr.Close();
        }
    }
}