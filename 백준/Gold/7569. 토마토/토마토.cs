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
        public static Tuple<int, int, int>[] dir = new Tuple<int, int, int>[6];
        public static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
        public static StreamReader sr = new StreamReader(Console.OpenStandardInput());

        public static int Bfs(int[,,] array, bool[,,] visited, int[,,] order, int maxX, int maxY, int maxZ)
        {
            ConcurrentQueue<Tuple<int, int, int>> queue = new ConcurrentQueue<Tuple<int, int, int>>();

            for (int i = 0; i < maxZ; i++)
            {
                for (int j = 0; j < maxY; j++)
                {
                    for (int k = 0; k < maxX; k++)
                    {
                        if (array[k, j, i] == 1)
                        {
                            queue.Enqueue(new Tuple<int, int, int>(k, j, i));
                            visited[k, j, i] = true;
                            order[k, j, i] = 0;
                        }
                    }
                }
            }

            while (queue.Count > 0)
            {
                Tuple<int, int, int> tuple;
                queue.TryDequeue(out tuple);
                int x = tuple.Item1;
                int y = tuple.Item2;
                int z = tuple.Item3;

                dir[0] = new Tuple<int, int, int>(x, y + 1, z);
                dir[1] = new Tuple<int, int, int>(x, y - 1, z);
                dir[2] = new Tuple<int, int, int>(x - 1, y, z);
                dir[3] = new Tuple<int, int, int>(x + 1, y, z);
                dir[4] = new Tuple<int, int, int>(x, y, z + 1);
                dir[5] = new Tuple<int, int, int>(x, y, z - 1);

                for (int i = 0; i < dir.Length; i++)
                {
                    int _x = dir[i].Item1;
                    int _y = dir[i].Item2;
                    int _z = dir[i].Item3;

                    if (_x < 0 || _y < 0 || _z < 0 || _x >= maxX || _y >= maxY || _z >= maxZ) continue;

                    if (!visited[_x, _y, _z] && array[_x, _y, _z] != -1 && array[_x, _y, _z] == 0)
                    {
                        array[_x, _y, _z] = 1;
                        visited[_x, _y, _z] = true;
                        order[_x, _y, _z] = order[x, y, z] + 1;
                        queue.Enqueue(new Tuple<int, int, int>(_x, _y, _z));
                    }
                }
            }

            bool isZero = false;
            for (int i = 0; i < maxZ; ++i)
            {
                for (int j = 0; j < maxY; ++j)
                {
                    for (int k = 0; k < maxX; ++k)
                    {
                        if (array[k, j, i] == 0)
                        {
                            isZero = true;
                            break;
                        }
                    }
                }
            }
            if (isZero) return -1;

            int max = 0;
            for (int z = 0; z < maxZ; z++)
            {
                for (int y = 0; y < maxY; y++)
                {
                    for (int x = 0; x < maxX; x++)
                    {
                        max = Math.Max(max, order[x, y, z]);
                    }
                }
            }

            return max;
        }

        public static void Main(string[] args)
        {
            string[] st = sr.ReadLine().Split();
            int M = int.Parse(st[0]);
            int N = int.Parse(st[1]);
            int Z = int.Parse(st[2]);

            int[,,] array = new int[M, N, Z];
            int[,,] order = new int[M, N, Z];
            bool[,,] visited = new bool[M, N, Z];

            for (int i = 0; i < Z; ++i)
            {
                for (int j = 0; j < N; ++j)
                {
                    st = sr.ReadLine().Split();
                    for (int k = 0; k < M; ++k)
                    {
                        array[k, j, i] = int.Parse(st[k]);
                    }
                }
            }

            sw.WriteLine(Bfs(array, visited, order, M, N, Z));

            sw.Flush();
            sw.Close();
            sr.Close();
        }
    }
}