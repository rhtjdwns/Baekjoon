using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project1
{
    class Program
    {
        public static void Main(string[] args)
        {
            int N;
            string result;
            Queue results = new Queue();

            N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; ++i)
            {
                StringBuilder builder = new StringBuilder();
                result = Console.ReadLine();
                builder.Append(result[0]);
                builder.Append(result[result.Length - 1]);
                results.Enqueue(builder.ToString());
            }

            for (int i = 0; i < N; ++i)
            {
                Console.WriteLine(results.Dequeue());
            }
        }
    }
}