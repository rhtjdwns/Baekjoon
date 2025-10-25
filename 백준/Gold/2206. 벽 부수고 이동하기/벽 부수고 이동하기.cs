using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Project2
{
    internal class main
    {
        public static int MAX = 101;
        public static int[,] dir = { { 0, -1}, { -1, 0 }, { 0, 1 }, { 1, 0 } };
        public static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
        public static StreamReader sr = new StreamReader(Console.OpenStandardInput());

        public static void Bfs(bool[,,] visited, int[,,] order, int[,] arr, int maxX, int maxY)
        {
            Queue queue = new Queue();
            queue.Enqueue(new Tuple<int, int, int>(0, 0, 0));

            visited[0, 0, 0] = true;
            order[0, 0, 0] = 1;

            while (queue.Count > 0)
            {
                Tuple<int, int, int> cur = (Tuple<int, int, int>)queue.Dequeue();
                int x = cur.Item1;
                int y = cur.Item2;
                int z = cur.Item3;

                for (int i = 0; i < 4; i++)
                {
                    int _x = x + dir[i, 0];
                    int _y = y + dir[i, 1];

                    if (_x < 0 || _y < 0 || _x >= maxX || _y >= maxY) continue;

                    if (arr[_x, _y] == 0 && !visited[_x, _y, z])
                    {
                        visited[_x, _y, z] = true;
                        if (order[_x, _y, z] == 0 || order[_x, _y, z] > order[x, y, z] + 1)
                        {
                            order[_x, _y, z] = order[x, y, z] + 1;
                        }
                        queue.Enqueue(new Tuple<int, int, int>(_x, _y, z));
                    }

                    if (arr[_x, _y] == 1 && !visited[_x, _y, 1] && z == 0)
                    {
                        visited[_x, _y, 1] = true;
                        if (order[_x, _y, 1] == 0 || order[_x, _y, 1] > order[x, y, 0] + 1)
                        {
                            order[_x, _y, 1] = order[x, y, 0] + 1;
                        }
                        queue.Enqueue(new Tuple<int, int, int>(_x, _y, 1));
                    }
                }
            }
        }

        public static void Main(string[] args)
        {
            string[] st = sr.ReadLine().Split();
            int N = int.Parse(st[0]);
            int M = int.Parse(st[1]);

            int[,] map = new int[M, N];
            bool[,,] visited = new bool[M, N, 2];
            int[,,] order = new int[M, N, 2];

            for (int i = 0; i < N; ++i)
            {
                var st2 = sr.ReadLine();
                for (int j = 0; j < M; ++j)
                {
                    map[j, i] = (int)st2[j] - 48;
                }
            }

            Bfs(visited, order, map, M, N);

            int res1 = order[M - 1, N - 1, 0];
            int res2 = order[M - 1, N - 1, 1];

            if (res1 == 0 && res2 == 0)
            {
                sw.WriteLine(-1);
            }
            else if (res1 == 0)
            {
                sw.WriteLine(res2);
            }
            else if (res2 == 0)
            {
                sw.WriteLine(res1);
            }
            else
            {
                sw.WriteLine(Math.Min(res1, res2));
            }

            sw.Flush();
            sw.Close();
            sr.Close();
        }
    }
}