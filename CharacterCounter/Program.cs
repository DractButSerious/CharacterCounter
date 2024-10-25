using System;
using System.Collections.Generic;
using System.Linq;

namespace CharCount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine().ToLower();

            // Use a dictionary to store character counts, making it case-insensitive
            Dictionary<char, int> charCounts = new Dictionary<char, int>();

            foreach (char c in input)
            {
                if (char.IsLetter(c))
                {
                    if (charCounts.ContainsKey(c))
                    {
                        charCounts[c]++;
                    }
                    else
                    {
                        charCounts[c] = 1;
                    }
                }
            }

            // Sort the dictionary by character count in descending order
            var sortedCounts = charCounts.OrderByDescending(x => x.Value);

            // Print the character counts
            foreach (var kvp in sortedCounts)
            {
                Console.WriteLine("{0}: {1}", kvp.Key, kvp.Value);
            }
        }
    }
}