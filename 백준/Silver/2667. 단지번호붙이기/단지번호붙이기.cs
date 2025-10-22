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

        public static void dfs(int[,] array, bool[,] visited, int x, int y, ref int count, int N)
        {
            count++;
            visited[x, y] = true;

            for (int i = 0; i < 4; ++i)
            {
                int _x = x + dirX[i];
                int _y = y + dirY[i];

                if (_x < 0 || _y < 0 || _x >= N || _y >= N) continue;

                if (!visited[_x, _y] && array[_x, _y] != 0)
                {
                    dfs(array, visited, _x, _y, ref count, N);
                }
            }
        }

        public static void Main(string[] args)
        {
            int N = int.Parse(sr.ReadLine());
            int[,] array = new int[N,N];
            bool[,] visited = new bool[N,N];
            List<int> results = new List<int>();    

            for (int i = 0; i < N; i++)
            {
                string st = sr.ReadLine();
                for (int j = 0; j < N; j++)
                {
                    array[i,j] = st[j] - 48;
                }
            }

            int count = 0;
            int amount = 0;

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (array[i, j] != 0 && !visited[i, j])
                    {
                        dfs(array, visited, i, j, ref count, N);
                        results.Add(count);
                        count = 0;
                        amount++;
                    }
                }
            }

            sw.WriteLine(amount);
            foreach (int v in results.OrderBy(x => x))
            {
                sw.WriteLine(v);
            }

            sw.Flush();
            sw.Close();
            sr.Close();
        }
    }
}