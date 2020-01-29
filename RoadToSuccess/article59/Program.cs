using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace article59
{
    class Program
    {
        static void Main(string[] args)
        {
            // var Friends = new List<string>();

            // while (true)
            // {
            //  Console.WriteLine("Please enter the names or enter to stop");
            //  var names = Console.ReadLine();
            // if (names.ToLower() == "enter" || string.IsNullOrWhiteSpace(names))
            //   {
            //    Console.WriteLine("Program exited successfully");
            //   break;
            // }

            //   Friends.Add(names);
            // }
            // if (Friends.Count==2)
            // {
            //     Console.WriteLine(string.Format("Your friend {0} and {1} liked your picture" ,Friends[0],Friends[1]));
            // }
            // if (Friends.Count > 2)
            //{
            //var last = Friends.GetRange(2, Friends.Count - 2);
            //  Console.WriteLine(string.Format("Your friend {0},{1} and {2} others liked your picture", Friends[0], Friends[1],last.Count));
            //}

                        
            Console.WriteLine("please enter your name");
            var name = Console.ReadLine();

            var arr = name.ToCharArray();

            var reversed = arr.Reverse();

            foreach(var n in reversed)
                Console.Write(n);

            Console.WriteLine();
            }
    }
}
