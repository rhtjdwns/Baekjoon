using System;
using System.Linq;

namespace Project1
{
    class Program
    {
        static string S, T;
        static int answer = 0;

        static void DFS(string current)
        {
            if (answer == 1) return;

            if (current.Length == S.Length)
            {
                if (current == S)
                    answer = 1;
                return;
            }

            if (current[current.Length - 1] == 'A')
            {
                DFS(current.Substring(0, current.Length - 1));
            }

            if (current[0] == 'B')
            {
                char[] arr = current.Substring(1).ToCharArray();
                Array.Reverse(arr);
                DFS(new string(arr));
            }
        }

        public static void Main(string[] args)
        {
            S = Console.ReadLine();
            T = Console.ReadLine();

            DFS(T);
            Console.WriteLine(answer);
        }
    }
}