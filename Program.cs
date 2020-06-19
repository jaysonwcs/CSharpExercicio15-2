using System;
using System.Collections.Generic;
using System.IO;

namespace Exercise15_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();

            Dictionary<string, int> votes = new Dictionary<string, int>();

            try
            {
                using StreamReader reader = File.OpenText(path);
                while (!reader.EndOfStream)
                {
                    string[] values = reader.ReadLine().Split(',');

                    if (votes.ContainsKey(values[0]))
                    {
                        votes[values[0]] += int.Parse(values[1]);
                    }
                    else
                    {
                        votes[values[0]] = int.Parse(values[1]);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error has ocurred:");
                Console.WriteLine(e.Message);
            }


            foreach (var item in votes)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }

        }
    }
}
