using System;

namespace Atcoder
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var str = Console.ReadLine();
            
            int lower = 0;
            int upper = 0;

            foreach (var c in str)
            {
                if (char.IsLower(c))
                {
                    lower++;
                }
                else if (char.IsUpper(c))
                {
                    upper++;
                }     
            }

            if (upper>lower)
            {
                str= str.ToUpper();
            }else
            {
                str= str.ToLower();
            }
           
            Console.WriteLine(str);
        }
    }
}