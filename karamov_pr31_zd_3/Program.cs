using System;
using System.Collections.Generic;

namespace karamov_pr31_zd_3
{
    class Program
    {
        static long FindMax(List<long> arr)
        {
            long max = long.MinValue;
            int index = 0;
            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                    index = i;
                }
            }
            arr[index] = long.MinValue;
            return index+1;
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            if (n >= 1 && n <= 30000)
            {
                string[] snowballs = Console.ReadLine().Split(' ');
                List<long> list = new List<long>();
                for (int i = 0; i < snowballs.Length; i++)
                {
                    list.Add(Convert.ToInt64(snowballs[i]));
                }
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine($"{FindMax(list)} {FindMax(list)}");
                }
            }
            Console.ReadLine();
        }
    }
}
