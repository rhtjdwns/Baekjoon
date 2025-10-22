using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    internal class main
    {
        public static int[] dirX = { 1, -1, 0, 0 };
        public static int[] dirY = { 0, 0, 1, -1 };
        public static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
        public static StreamReader sr = new StreamReader(Console.OpenStandardInput());

        public static void bfs(int[,] array, bool[,] visited, int[,] order, int x, int y, int MaxX, int MaxY, ref int count)
        {
            List<Tuple<int, int>> list = new List<Tuple<int, int>>();
            list.Add(new Tuple<int, int>(x, y));

            visited[x, y] = true;
            order[x, y] = count++;

            while (list.Count > 0)
            {
                Tuple<int, int> now = list.First();
                list.RemoveAt(0);

                for (int i = 0; i < 4; ++i)
                {
                    int _x = now.Item1 + dirX[i];
                    int _y = now.Item2 + dirY[i];

                    if (_x < 0 || _y < 0 || _x >= MaxX || _y >= MaxY) continue;

                    if (!visited[_x, _y] && array[_x, _y] != 0)
                    {
                        list.Add(new Tuple<int, int>(_x, _y));
                        order[_x, _y] = order[now.Item1, now.Item2] + 1;
                        visited[_x, _y] = true;
                    }
                }
            }
        }

        public static void Main(string[] args)
        {
            string[] st = sr.ReadLine().Split();
            int N = int.Parse(st[0]);
            int M = int.Parse(st[1]);

            int[,] array = new int[N, M];
            int[,] order = new int[N, M];
            bool[,] visited = new bool[N, M];

            for (int x = 0; x < N; ++x)
            {
                string s = sr.ReadLine();
                for (int y = 0; y < M; ++y)
                {
                    array[x, y] = s[y] - 48;
                }
            }

            int count = 1;
            bfs(array, visited, order, 0, 0, N, M, ref count);

            sw.WriteLine(order[N - 1, M - 1]);

            sw.Flush();
            sw.Close();
            sr.Close();
        }
    }
}