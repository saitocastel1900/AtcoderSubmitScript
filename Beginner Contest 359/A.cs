using System;

namespace Atcoder
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());

            int count = 0;
            for (int i = 0; i < N; i++)
            {
                var S = Console.ReadLine();
                if ("Takahashi"== S)
                {
                    count++;
                }
            }
            
            Console.Write(count);
        }
    }
}