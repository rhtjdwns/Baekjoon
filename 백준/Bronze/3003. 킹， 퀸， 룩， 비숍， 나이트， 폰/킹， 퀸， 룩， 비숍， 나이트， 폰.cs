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
            int[] array = { 1, 1, 2, 2, 2, 8 };
            int result = 0;
            string st = Console.ReadLine();
            string[] sp = st.Split();
            
            for (int i = 0; i < 6; ++i)
            {
                result = int.Parse(sp[i]);
                Console.Write(array[i] - result + " ");
            }
        }
    }
}