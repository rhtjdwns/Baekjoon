using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Project2
{
    internal class main
    {
        public static int MAX = 101;
        public static int[] dir = { 1, 2, 3, 4, 5, 6 };
        public static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
        public static StreamReader sr = new StreamReader(Console.OpenStandardInput());

        public static void Bfs(bool[] visited, int[] order, int[] arr)
        {
            Queue queue = new Queue();
            queue.Enqueue(1);

            visited[1] = true;
            order[1] = 0;

            while (queue.Count > 0)
            {
                int x = (int)queue.Dequeue();

                for (int i = 0; i < dir.Length; i++)
                {
                    int temp = x + dir[i];

                    if (temp > MAX - 1) continue;

                    if (arr[temp] != 0)
                    {
                        temp = arr[temp];
                    }

                    if (!visited[temp])
                    {
                        visited[temp] = true;
                        order[temp] = order[x] + 1;
                        queue.Enqueue(temp);
                    }
                }
            }
        }

        public static void Main(string[] args)
        {
            string[] st = sr.ReadLine().Split();
            int N = int.Parse(st[0]);
            int M = int.Parse(st[1]);

            int[] array = new int[MAX];
            bool[] visited = new bool[MAX];
            int[] order = new int[MAX];
            int[] arr = new int[MAX];

            for (int i = 0; i < N + M; i++)
            {
                st = sr.ReadLine().Split();

                arr[int.Parse(st[0])] = int.Parse(st[1]);
                visited[int.Parse(st[0])] = true;
            }

            Bfs(visited, order, arr);

            sw.WriteLine(order[100]);

            sw.Flush();
            sw.Close();
            sr.Close();
        }
    }
}