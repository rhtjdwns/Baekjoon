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
        public static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
        public static StreamReader sr = new StreamReader(Console.OpenStandardInput());

        public static void dfs(List<int>[] lists, List<int> results, int a, bool[] visited, ref int count)
        {
            visited[a] = true;
            results.Add(a);

            foreach (int v in lists[a].OrderBy(x => x))
            {
                if (!visited[v])
                {
                    dfs(lists, results, v, visited, ref count);
                }
            }
        }

        public static void bfs(List<int>[] lists, List<int> results, int a, bool[] visited, ref int count)
        {
            Queue queue = new Queue();
            queue.Enqueue(a);

            visited[a] = true;
            sw.Write(a + " ");

            while (queue.Count > 0)
            {
                int temp = (int)queue.Dequeue();
                foreach (int v in lists[temp].OrderBy(x => x))
                {
                    if (!visited[v])
                    {
                        visited[v] = true;
                        queue.Enqueue(v);
                        results.Add(v);
                    }
                }
            }
        }

        public static void Main(string[] args)
        {
            string[] st = sr.ReadLine().Split();
            int N = int.Parse(st[0]);
            int M = int.Parse(st[1]);
            int R = int.Parse(st[2]);

            List<int>[] lists = new List<int>[N + 1];
            bool[] visited = new bool[N + 1];
            List<int> results = new List<int>();

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

            int count = 1;

            dfs(lists, results, R, visited, ref count);

            for (int i = 0; i < results.Count; i++)
            {
                sw.Write(results[i] + " ");
            }
            sw.WriteLine();

            count = 1;
            visited = new bool[N + 1];
            results = new List<int>();

            bfs(lists, results, R, visited, ref count);

            for (int i = 0; i < results.Count; i++)
            {
                sw.Write(results[i] + " ");
            }

            sw.Flush();
            sw.Close();
            sr.Close();
        }
    }
}