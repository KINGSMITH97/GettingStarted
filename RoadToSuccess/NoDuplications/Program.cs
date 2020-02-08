using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoDuplications
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter the numbers separated by a hyphen (eg 1-2-3-4): ");
            var UserInput = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(UserInput))
                return;

            var numbers = new List<int>();
            foreach (var number in UserInput.Split('-'))
                numbers.Add(Convert.ToInt32(number));

            var SameNumbers = new List<int>();

            var includeDuplicates = false;
            foreach (var number in numbers)
            {
                if (!SameNumbers.Contains(number))
                {
                    SameNumbers.Add(number);
                }
                else
                {
                    includeDuplicates = true;
                    break;
                }
            }

            if (includeDuplicates)
            {
                Console.WriteLine("Duplicate");
            }
            else
                Console.WriteLine("No dupliccates");
                
        }
    
    }
}
