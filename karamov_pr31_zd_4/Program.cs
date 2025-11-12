using System;
using System.Collections.Generic;

namespace karamov_pr31_zd_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            string[] message = Console.ReadLine().Split(' ');
            string[] newspaper = Console.ReadLine().Split(' ');
            Dictionary<string, int> avaible = new Dictionary<string, int>();
            if (Convert.ToInt32(input[0]) == message.Length && Convert.ToInt32(input[1]) == newspaper.Length)
            {
                foreach (string word in newspaper)
                {
                    if (avaible.ContainsKey(word))
                    {
                        avaible[word]++;
                    }
                    else
                    {
                        avaible[word] = 1;
                    }
                }
                foreach (string word in message)
                {
                    if (avaible.ContainsKey(word) && avaible[word] > 0)
                    {
                        avaible[word]--;
                    }
                    else
                    {
                        Console.WriteLine(word);
                        return;
                    }
                }
                Console.WriteLine("GOOD WORD");
            }
            Console.ReadLine();
        }
    }
}
