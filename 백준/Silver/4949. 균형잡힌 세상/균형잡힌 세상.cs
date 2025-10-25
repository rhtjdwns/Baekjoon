using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Project2
{
    internal class main
    {
        public static StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
        public static StreamReader sr = new StreamReader(Console.OpenStandardInput());

        public static void Main(string[] args)
        {
            string st = "";

            while (true)
            {
                Stack stack = new Stack();
                bool isComplete = false;

                st = sr.ReadLine();
                if (st.Length == 1 && st[0] == '.') break;

                for (int i = 0; i < st.Length; i++)
                {
                    if (st[i] == '(')
                    {
                        stack.Push(1);
                    }
                    if (st[i] == '[')
                    {
                        stack.Push(2);
                    }
                    if (st[i] == ')')
                    {
                        if (stack.Count <= 0)
                        {
                            stack.Push(2);
                            break;
                        }

                        int s = (int)stack.Pop();
                        if (s == 2)
                        {
                            stack.Push(2);
                            break;
                        }
                    }
                    if (st[i] == ']')
                    {
                        if (stack.Count <= 0)
                        {
                            stack.Push(1);
                            break;
                        }

                        int s = (int)stack.Pop();
                        if (s == 1)
                        {
                            stack.Push(1);
                            break;
                        }
                    }
                }

                if (stack.Count <= 0) isComplete = true;

                if (!isComplete)
                {
                    sw.WriteLine("no");
                }
                else
                {
                    sw.WriteLine("yes");
                }
            }

            sw.Flush();
            sw.Close();
            sr.Close();
        }
    }
}