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
            string result = "";

            num = Console.ReadLine();
            sp = num.Split();

            count = int.Parse(sp[0]);

            while (count != 0)
            {
                int temp = count % int.Parse(sp[1]);
                if (temp >= 10) result += (char)(temp - 10 + 'A');
                else result += temp.ToString();
                count /= int.Parse(sp[1]);
            }
            result = new string(result.Reverse().ToArray());

            Console.WriteLine(result);
        }
    }
}