using System;
using System.IO;

namespace karamov_pr31_zd_5
{
    class Program
    {
        static void Main(string[] args)
        {
            if (!File.Exists("input.txt"))
            {
                File.CreateText("input.txt");
            }
            string[] lines = File.ReadAllLines("input.txt");
            string[] first = lines[0].Split(' ');
            int N = int.Parse(first[0]);
            int C = Convert.ToInt32(first[1]);
            int phones = 0;
            for (int i = 1; i <= N; i++)
            {
                int voters = int.Parse(lines[i]);
                int needed = voters / 2 + 1;
                phones += needed;
            }
            File.WriteAllText("output.txt", $"{phones * C}");
        }
    }
}
