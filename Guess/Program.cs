using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guess
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int returnValue = random.Next(1, 100);
            int Guess = 0;

            Console.WriteLine("I'm thinking of a number between 1 and 100, Guess which one.");

            while(Guess != returnValue)
            {
                Guess = Convert.ToInt32(Console.ReadLine());

                if(Guess < returnValue)
                {
                    Console.WriteLine("Your number is to low, please guess again");
                }

                else if(Guess > returnValue)
                {
                    Console.WriteLine("Your number is to high, please guess again");
                }
            }

         Console.WriteLine("Nice job! The answer was " + returnValue);
        }
    }
}
