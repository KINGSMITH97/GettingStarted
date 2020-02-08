using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vowelcount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a word");

            var input = Console.ReadLine();
            input.ToLower();

            var vowels = new List<char>() { 'a', 'e', 'o', 'u', 'i' };
            var CountVowels = 0;
            foreach(var word in input)
            {
                if (vowels.Contains(word))
                {
                    CountVowels++;
                }
            }
            Console.WriteLine("Number of vowels: " + CountVowels);
        }
    }
}
