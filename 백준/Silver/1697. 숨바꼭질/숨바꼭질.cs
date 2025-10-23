using System;
using System.Collections;
using System.IO;

namespace Project2
{
    internal class main
    {
        public static int MAX = 100001;
        public static int[] dir = new int[3];
        public static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
        public static StreamReader sr = new StreamReader(Console.OpenStandardInput());

        public static void bfs(bool[] visited, int[] order, int x, int target)
        {
            Queue queue = new Queue();
            queue.Enqueue(x);

            visited[x] = true;
            order[x] = 0;

            while (queue.Count > 0)
            {
                if (visited[target])
                    break;

                int _x = (int)queue.Dequeue();
                dir[0] = _x + 1;
                dir[1] = _x - 1;
                dir[2] = _x * 2;

                for (int i = 0; i < dir.Length; i++)
                {
                    if (dir[i] >= MAX || dir[i] < 0) continue;

                    if (!visited[dir[i]])
                    {
                        visited[dir[i]] = true;
                        order[dir[i]] = order[_x] + 1;
                        queue.Enqueue(dir[i]);
                    }
                }
            }
        }

        public static void Main(string[] args)
        {
            string[] st = sr.ReadLine().Split();
            int N = int.Parse(st[0]);
            int K = int.Parse(st[1]);

            int[] order = new int[MAX];
            bool[] visited = new bool[MAX];

            bfs(visited, order, N, K);

            sw.WriteLine(order[K]);

            sw.Flush();
            sw.Close();
            sr.Close();
        }
    }
}