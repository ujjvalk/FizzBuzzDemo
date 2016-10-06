using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int number = 1; number <= 100; number++)
            {
                Console.WriteLine(DoFizzBuzzOutput(number));
            }
            Console.ReadLine();
        }

        public static string DoFizzBuzzOutput(int number)
        {
            string output = string.Empty;
            if (number % 3 == 0)
            {
                output = "Fizz";
            }
            if (number % 5 == 0)
            {
                output += "Buzz";
            }
            if (string.IsNullOrEmpty(output))
            {
                output = number.ToString();
            }
            return output;
        }
    }
}
