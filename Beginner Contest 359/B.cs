using System;
using System.Collections.Generic;

namespace Atcoder
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());
            
            Dictionary<int, List<int>> positions = new Dictionary<int, List<int>>();
            for (int i = 1; i <= N; i++)
            {
                positions[i] = new List<int>();
            }
            
            var values = Console.ReadLine().Split(' ');
            for (int i = 0; i < N * 2; i++)
            {
                var A = int.Parse(values[i]);
                positions[A].Add(i);
            }
            
            int count = 0;
            for (int i = 1; i <= N; i++)
            {
                List<int> pos = positions[i];
                if (pos.Count == 2 && Math.Abs(pos[0] - pos[1]) == 2)
                {
                    count++;
                }
            }

            Console.Write(count);
        }
    }
}