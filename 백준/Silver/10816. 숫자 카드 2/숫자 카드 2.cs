using System;
using System.Text;

namespace Project1
{
    class Program
    {
        public static int Lower(int[] list, int target)
        {
            int mid, left, right;
            left = 0;
            right = list.Length;
            while (left < right)
            {
                mid = (left + right) / 2;
                if (list[mid] < target) left = mid + 1;
                else right = mid;
            }
            return left;
        }

        public static int Upper(int[] list, int target)
        {
            int mid, left, right;
            left = 0;
            right = list.Length;
            while (left < right)
            {
                mid = (left + right) / 2;
                if (list[mid] <= target) left = mid + 1;
                else right = mid;
            }
            return left;
        }

        public static void Main(string[] args)
        {
            string st;
            string[] sp;
            int N, M;
            int[] array;
            int[] result;
            StringBuilder stringBuilder = new StringBuilder();

            N = int.Parse(Console.ReadLine());
            array = new int[N];

            st = Console.ReadLine();
            sp = st.Split();

            for (int i = 0; i < N; ++i)
            {
                array[i] = int.Parse(sp[i]);
            }

            Array.Sort(array);

            M = int.Parse(Console.ReadLine());
            result = new int[M];

            st = Console.ReadLine();
            sp = st.Split();

            for (int i = 0; i < M; ++i)
            {
                int start = Lower(array, int.Parse(sp[i]));
                int end = Upper(array, int.Parse(sp[i]));
                result[i] = end - start;
                stringBuilder.Append(result[i] + " ");
            }

            Console.WriteLine(stringBuilder);
        }
    }
}