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
        public static Tuple<int, int>[] dir = new Tuple<int, int>[4];
        public static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
        public static StreamReader sr = new StreamReader(Console.OpenStandardInput());

        public static int Bfs(int[,] array, bool[,] visited, int[,] order, int maxX, int maxY)
        {
            ConcurrentQueue<Tuple<int, int>> queue = new ConcurrentQueue<Tuple<int, int>>();

            for (int i = 0; i < maxY; i++)
            {
                for (int j = 0; j < maxX; j++)
                {
                    if (array[j, i] == 1)
                    {
                        queue.Enqueue(new Tuple<int, int>(j, i));
                        visited[j, i] = true;
                        order[j, i] = 0;
                    }
                }
            }

            while (queue.Count > 0)
            {
                Tuple<int, int> tuple;
                queue.TryDequeue(out tuple);
                int x = tuple.Item1;
                int y = tuple.Item2;

                dir[0] = new Tuple<int, int>(x, y + 1);
                dir[1] = new Tuple<int, int>(x, y - 1);
                dir[2] = new Tuple<int, int>(x - 1, y);
                dir[3] = new Tuple<int, int>(x + 1, y);

                for (int i = 0; i < dir.Length; i++)
                {
                    int _x = dir[i].Item1;
                    int _y = dir[i].Item2;

                    if (_x < 0 || _y < 0 || _x >= maxX || _y >= maxY) continue;

                    if (!visited[_x, _y] && array[_x, _y] != -1 && array[_x, _y] == 0)
                    {
                        array[_x, _y] = 1;
                        visited[_x, _y] = true;
                        order[_x, _y] = order[x, y] + 1;
                        queue.Enqueue(new Tuple<int, int>(_x, _y));
                    }
                }
            }

            bool isZero = false;
            for (int i = 0; i < maxY; ++i)
            {
                for (int j = 0; j < maxX; ++j)
                {
                    if (array[j, i] == 0)
                    {
                        isZero = true;
                        break;
                    }
                }
            }
            if (isZero) return -1;

            int max = 0;
            for (int arrayY = 0; arrayY < maxY; arrayY++)
            {
                for (int arrayX = 0; arrayX < maxX; arrayX++)
                {
                    max = Math.Max(max, order[arrayX, arrayY]);
                }
            }

            return max;
        }

        public static void Main(string[] args)
        {
            string[] st = sr.ReadLine().Split();
            int M = int.Parse(st[0]);
            int N = int.Parse(st[1]);

            int[,] array = new int[M, N];
            int[,] order = new int[M, N];
            bool[,] visited = new bool[M, N];

            for (int i = 0; i < N; ++i)
            {
                st = sr.ReadLine().Split();
                for (int j = 0; j < M; ++j)
                {
                    array[j, i] = int.Parse(st[j]);
                }
            }

            sw.WriteLine(Bfs(array, visited, order, M, N));

            sw.Flush();
            sw.Close();
            sr.Close();
        }
    }
}