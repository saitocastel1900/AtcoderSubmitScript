using System;
using System.Collections.Generic;

namespace Atcoder
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var S = Console.ReadLine().Split(' ');
            var T = Console.ReadLine().Split(' ');

            var currentPos = new long[] { long.Parse(S[0]), long.Parse(S[1]) };
            var targetPos = new long[] { long.Parse(T[0]), long.Parse(T[1]) };
            long count = 0;

            while (currentPos[0] != targetPos[0] || currentPos[1] != targetPos[1])
            {
                if (currentPos[0] > targetPos[0])
                {
                    currentPos[0]--;
                }
                else if (currentPos[0] < targetPos[0])
                {
                    currentPos[0]++;
                }
                else if (currentPos[1] < targetPos[1])
                {
                    currentPos[1]++;
                    count ++;
                }
            }
            
            Console.WriteLine(count <= 4 ? count : 5);
        }
    }
}