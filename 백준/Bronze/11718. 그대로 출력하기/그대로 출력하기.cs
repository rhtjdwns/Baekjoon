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
            string result;

            while (true)
            {
                result = Console.ReadLine()??"";
                if (result == "") break;
                Console.WriteLine(result);
            }
        }
    }
}