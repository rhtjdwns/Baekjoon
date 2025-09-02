using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Project1
{
    class Program
    {
        public static void Main(string[] args)
        {
            int money = 0;
            int T;
            string[] results;

            T = int.Parse(Console.ReadLine());
            results = new string[T];

            for (int i = 0; i < T; ++i)
            {
                money = int.Parse(Console.ReadLine());

                results[i] += ((money / 25).ToString() + " ");
                money -= (money / 25) * 25;

                results[i] += ((money / 10).ToString() + " ");
                money -= (money / 10) * 10;

                results[i] += ((money / 5).ToString() + " ");
                money -= (money / 5) * 5;

                results[i] += money;
            }

            for (int i = 0; i < T; ++i)
            {
                Console.WriteLine(results[i]);
            }
        }
    }
}