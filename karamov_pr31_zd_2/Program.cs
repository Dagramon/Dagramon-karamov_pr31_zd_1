using System;

namespace karamov_pr31_zd_2
{
    class Program
    {
        static void Main(string[] args)
        {
            short n = Convert.ToInt16(Console.ReadLine());
            if (n >= 1 && n <= 20)
            {
                string[] words = new string[n];
                for (int i = 0; i < n; i++)
                {
                    words[i] = Console.ReadLine();
                }
                foreach (string s in words)
                {
                    string check1 = "";
                    string check2 = "";
                    for (int i = 0; i < s.Length; i++)
                    {
                        check1 += char.ToUpper(s[i]);
                    }
                    for (int i = s.Length - 1; i >= 0; i--)
                    {
                        check2 += char.ToUpper(s[i]);
                    }
                    if (check1 == check2)
                    {
                        Console.WriteLine("YES");
                    }
                    else
                    {
                        Console.WriteLine("NO");
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
