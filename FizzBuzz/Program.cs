using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 30;
            for (int i = 0; i <= x; i++)
            {
                FizzBuzz(i);
                Console.Write(" ");
            }

        }

        private static void Fizz(int x)
        {
            if((x%3) == 0)
            {
                Console.Write("Fizz ");
            }

        }

        private static void Buzz(int x)
        {
            if((x%5) == 0)
            {
                Console.Write("Buzz ");
            }

        }

        private static void FizzBuzz(int x)
        {
            Fizz(x);
            Buzz(x);
            Console.WriteLine(":Next. ");
        }
    }
}
