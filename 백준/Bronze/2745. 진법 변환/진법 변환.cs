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
            string num;
            string[] sp;
            int count = 0;

            num = Console.ReadLine();
            sp = num.Split();

            char[] code = sp[0].ToCharArray();

            for (int i = 0; i < code.Length; ++i)
            {
                int a;
                a = code[code.Length - i - 1] - '0';
                if (code[code.Length - i - 1] >= 'A') a -= 7;

                count += a * (int)Math.Pow(int.Parse(sp[1]), i);
            }

            Console.WriteLine(count);
        }
    }
}