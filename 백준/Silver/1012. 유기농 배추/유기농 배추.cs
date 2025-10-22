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
        public static int[] dirX = { 1, -1, 0, 0 };
        public static int[] dirY = { 0, 0, 1, -1 };
        public static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
        public static StreamReader sr = new StreamReader(Console.OpenStandardInput());

        public static void dfs(int[,] array, bool[,] visited, int x, int y, int MaxX, int MaxY)
        {
            visited[x, y] = true;

            for (int i = 0; i < 4; ++i)
            {
                int _x = x + dirX[i];
                int _y = y + dirY[i];

                if (_x < 0 || _y < 0 || _x >= MaxX || _y >= MaxY) continue;

                if (!visited[_x, _y] && array[_x, _y] != 0)
                {
                    dfs(array, visited, _x, _y, MaxX, MaxY);
                }
            }
        }

        public static void Main(string[] args)
        {
            int T = int.Parse(sr.ReadLine());

            for (int i = 0; i < T; ++i)
            {
                string[] st = sr.ReadLine().Split();
                int N = int.Parse(st[0]);
                int M = int.Parse(st[1]);
                int K = int.Parse(st[2]);

                int[,] array = new int[N, M];
                bool[,] visited = new bool[N, M];

                for (int x = 0; x < N; ++x)
                {
                    for (int y = 0; y < M; ++y)
                    {
                        array[x, y] = 0;
                    }
                }

                for (int j = 0; j < K; ++j)
                {
                    st = sr.ReadLine().Split();
                    int _x = int.Parse(st[0]);
                    int _y = int.Parse(st[1]);

                    array[_x, _y] = 1;
                }

                int count = 0;

                for (int x = 0; x < N; ++x)
                {
                    for (int y = 0; y < M; ++y)
                    {
                        if (array[x, y] != 0 && !visited[x, y])
                        {
                            dfs(array, visited, x, y, N, M);
                            count++;
                        }
                    }
                }
                sw.WriteLine(count);
            }

            sw.Flush();
            sw.Close();
            sr.Close();
        }
    }
}