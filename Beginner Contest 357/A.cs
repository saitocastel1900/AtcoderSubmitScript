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
            var H = new int[N];
            for (int i = 0; i < N; i++)
            {
                H[i] = int.Parse(values[i]);
            }

            int people = 0;
            int total = 0;
            for (int i = 0; i < N; i++)
            {
                total += H[i];

                if (total > M)
                {
                    break;
                }

                people++;
            }

            Console.WriteLine(people);
        }
    }
}