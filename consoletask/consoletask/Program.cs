using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoletask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.Title = "HW1 task";

            Console.WriteLine("Changed Title: {0}", Console.Title);

            Console.WriteLine("Nikolay Sakovets");

            int age = 28;

            Console.WriteLine($"I live in Minsk and I\'m {age}");

            Console.ReadKey();
        }
    }
}
