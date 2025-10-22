using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    internal class Test
    {
        public static void bfs(List<int>[] lists, int a, bool[] visited, ref int count)
        {
            Queue queue = new Queue();
            queue.Enqueue(a);

            visited[a] = true;

            while (queue.Count > 0)
            {
                int temp = (int)queue.Dequeue();
                foreach (int v in lists[temp].OrderBy(x => x))
                {
                    if (!visited[v])
                    {
                        visited[v] = true;
                        count++;
                        queue.Enqueue(v);
                    }
                }
            }
        }

        public static void Main(string[] args)
        {
            var sw = new StreamWriter(Console.OpenStandardOutput());
            var sr = new StreamReader(Console.OpenStandardInput());

            int N = int.Parse(sr.ReadLine());
            int M = int.Parse(sr.ReadLine());

            List<int>[] lists = new List<int>[N + 1];
            bool[] visited = new bool[N + 1];

            for (int i = 1; i <= N; i++)
            {
                lists[i] = new List<int>();
            }

            for (int i = 0; i < M; i++)
            {
                string[] edge = sr.ReadLine().Split();
                int a = int.Parse(edge[0]);
                int b = int.Parse(edge[1]);
                lists[a].Add(b);
                lists[b].Add(a);
            }

            int count = 0;
            bfs(lists, 1, visited, ref count);

            sw.WriteLine(count);

            sw.Flush();
            sw.Close();
            sr.Close();
        }
    }
}