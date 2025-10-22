using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    internal class Test
    {
        public static void dfs(List<int>[] lists, int a, int[] order, bool[] visited, ref int count)
        {
            visited[a] = true;
            order[a] = count++;

            foreach (int v in lists[a].OrderByDescending(x => x))
            {
                if (!visited[v])
                {
                    dfs(lists, v, order, visited, ref count);
                }
            }
        }

        public static void Main(string[] args)
        {
            var sw = new StreamWriter(Console.OpenStandardOutput());
            var sr = new StreamReader(Console.OpenStandardInput());

            string[] input = sr.ReadLine().Split();
            int N = int.Parse(input[0]);
            int M = int.Parse(input[1]);
            int R = int.Parse(input[2]);

            List<int>[] lists = new List<int>[N + 1];
            bool[] visited = new bool[N + 1];
            int[] order = new int[N + 1];

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
            dfs(lists, R, order, visited, ref count);

            for (int i = 1; i <= N; i++)
            {
                sw.WriteLine(visited[i] ? order[i] : 0);
            }

            sw.Flush();
            sw.Close();
            sr.Close();
        }
    }
}