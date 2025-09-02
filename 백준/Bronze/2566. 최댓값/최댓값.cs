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
            string num;
            string[] sp;
            int result = -1;
            string resultString = "";

            for (int i = 0; i < 9; ++i)
            {
                num = Console.ReadLine();
                sp = num.Split();
                for (int j = 0; j < 9; ++j)
                {
                    if (result < int.Parse(sp[j]))
                    {
                        result = int.Parse(sp[j]);
                        resultString = (i + 1) + " " + (j + 1);
                    }
                }
            }

            Console.WriteLine(result);
            Console.WriteLine(resultString);
        }
    }
}