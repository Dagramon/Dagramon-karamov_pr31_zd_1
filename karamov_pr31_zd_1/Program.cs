using System;
using System.IO;

namespace karamov_pr31_zd_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int k = Convert.ToInt16(inputs[0]);
            long n = Convert.ToInt64(inputs[1]);
            if ((k <= 100 && k >= 1) && (n >= 0 && n <= Math.Pow(10, 4)))
            {
                Console.WriteLine(n/k);
            }
            Console.ReadLine();
        }
    }
}
