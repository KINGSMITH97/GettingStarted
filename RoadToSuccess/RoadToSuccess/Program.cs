using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadToSuccess
{
    class Program
    {
        static void Main(string[] args)
        {
            //article 52 Question number one 

            //   var count = 0;
            //   var number = 0;
            //   for (var i=1; i<100; i++)
            //   {

            //     if (i%3==0)
            //     {
            //         number = i;
            //         count++;
            //     }

            //  }
            //  Console.WriteLine(count);

            //article 45 Question number two


            //var SumOfNumbers = 0;
            //while (true)
            // {
            //Console.WriteLine("Please enter a number or enter 'ok' to exit ");
            //var UserInput = Console.ReadLine();
            //if (UserInput == "ok")
            // {
            //Console.WriteLine("Program exited successfully");
            // break;
            // }
            // SumOfNumbers += Convert.ToInt32(UserInput);
            //}
            //  Console.WriteLine("Sum of numbers is "+SumOfNumbers);

            //article 45 Question number three 
            // var factorial = 1;
            //int number;
            //Console.WriteLine("Please enter a number to be calculated");
            //number = Convert.ToInt32(Console.ReadLine());
            //for (int i=1; i<=number; i++)
            //{
            //factorial = factorial * i;
            //}
            //Console.WriteLine("factorial is " + factorial);



            //article 45 Question number 4
            //var random = new Random();
            //var winningNumber = random.Next(1,10); 
            //for (int i=1; i<5; i++)
            //{
            //Console.WriteLine("Please guess a number");
            //var GuessNumber = Convert.ToInt32(Console.ReadLine());
            //if (GuessNumber == winningNumber)
            //{
            //Console.WriteLine("Congratulations you won");
            //break;
            //}
            //      else
            //{
            //Console.WriteLine("Wrong guess try again");
            //}
            // }


            //article 45 Question 5 
            Console.WriteLine("Please a series of numbers separated by a space ");
            var UserInput = Console.ReadLine();

            var numbers = UserInput.Split(' ');

            var max = Convert.ToInt32(numbers[0]);
            foreach(var number in numbers)
            {
                var num = Convert.ToInt32(number);

                if (num>max)
                {
                    max = num;
                }

            }
            Console.WriteLine("the maximum number is " + max);
        }


    }
}
