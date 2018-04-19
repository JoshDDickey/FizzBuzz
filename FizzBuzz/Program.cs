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
            //Declaring Variables
            string isFizz = "Fizz";
            string isBuzz = "Buzz";

            //Counting to 100 for FizzBuzz game
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)  //Prints "FizzBuzz" if i is divisible by 3 and 5
                {
                    Console.WriteLine(isFizz + isBuzz);
                }
                else if (i % 3 == 0)  //Prints "Fizz" if i is divisible by 3
                {
                    Console.WriteLine(isFizz);
                }
                else if (i % 5 == 0)  //Prints "Buzz" if i is divisible by 5
                {
                    Console.WriteLine(isBuzz);
                }
                else  //Otherwise just prints i
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadLine();
        }
    }
}
