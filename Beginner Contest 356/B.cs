using System;

namespace Atcoder
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var values = Console.ReadLine().Split(' ');
            var N = int.Parse(values[0]);
            var M = int.Parse(values[1]);

            values = Console.ReadLine().Split(' ');
            var A = new int[M];
            for (int i = 0; i < M; i++)
            {
                A[i] = int.Parse(values[i]);
            }

            var X = new int[N, M];
            for (int i = 0; i < N; i++)
            {
                values = Console.ReadLine().Split(' ');
                for (int j = 0; j < M; j++)
                {
                    X[i, j] = int.Parse(values[j]);
                }
            }

            //ここの名前は何とかする
            var isAchieved = true;
            for (int i = 0; i < N; i++)
            {
                int total = 0;
                for (int j = 0; j < M; j++)
                {
                    total += X[i, j];
                }

                if (total < A[i])
                {
                    isAchieved = false;
                    break;
                }
            }

            if (isAchieved)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}