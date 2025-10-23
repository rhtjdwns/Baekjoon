using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Project2
{
    internal class main
    {
        public static Tuple<int, int>[] dir = new Tuple<int, int>[8];
        public static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
        public static StreamReader sr = new StreamReader(Console.OpenStandardInput());

        public static void bfs(bool[,] visited, int[,] order, int originX, int originY, int targetX, int targetY, int MAX)
        {
            List<Tuple<int, int>> list = new List<Tuple<int, int>>();
            list.Add(new Tuple<int, int>(originX, originY));

            visited[originX, originY] = true;
            order[originX, originY] = 0;

            while (list.Count > 0)
            {
                int x = list.First().Item1;
                int y = list.First().Item2;
                list.RemoveAt(0);

                dir[0] = new Tuple<int, int>(x - 1, y + 2);
                dir[1] = new Tuple<int, int>(x + 1, y + 2);
                dir[2] = new Tuple<int, int>(x - 2, y + 1);
                dir[3] = new Tuple<int, int>(x + 2, y + 1);
                dir[4] = new Tuple<int, int>(x - 2, y - 1);
                dir[5] = new Tuple<int, int>(x + 2, y - 1);
                dir[6] = new Tuple<int, int>(x - 1, y - 2);
                dir[7] = new Tuple<int, int>(x + 1, y - 2);

                for (int i = 0; i < dir.Length; i++)
                {
                    if (dir[i].Item1 < 0 || dir[i].Item2 < 0 || dir[i].Item1 >= MAX || dir[i].Item2 >= MAX) continue;

                    if (!visited[dir[i].Item1, dir[i].Item2])
                    {
                        visited[dir[i].Item1, dir[i].Item2] = true;
                        order[dir[i].Item1, dir[i].Item2] = order[x, y] + 1;
                        if (visited[targetX, targetY]) return;
                        list.Add(dir[i]);
                    }
                }
            }
        }

        public static void Main(string[] args)
        {
            int T = int.Parse(sr.ReadLine());

            for (int i = 0; i < T; ++i)
            {
                int I = int.Parse(sr.ReadLine());

                string[] st = sr.ReadLine().Split();
                int originX = int.Parse(st[0]);
                int originY = int.Parse(st[1]);

                st = sr.ReadLine().Split();
                int targetX = int.Parse(st[0]);
                int targetY = int.Parse(st[1]);

                int[,] order = new int[I,I];
                bool[,] visited = new bool[I,I];

                bfs(visited, order, originX, originY, targetX, targetY, I);
                sw.WriteLine(order[targetX, targetY]);
            }

            sw.Flush();
            sw.Close();
            sr.Close();
        }
    }
}