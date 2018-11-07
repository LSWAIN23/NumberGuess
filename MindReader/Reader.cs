using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindReader
{
    class Reader
    {
        static public void BinarySearch()
        {
            int min = 1;
            int max = 100;
            int computerguess = max / 2;

            Console.WriteLine("Please enter a number from 1 to 10 and I will try to guess it.");
            int userInput = Convert.ToInt32(Console.ReadLine());

            while (computerguess != userInput)
            {
                Console.WriteLine($"Is your number: {computerguess}?\t(y/n)");
                string userResponce = Console.ReadLine();

                if (userResponce == "n")
                {
                    Console.WriteLine("Am I to high or to low?\t(h/l)");
                    userResponce = Console.ReadLine();

                    if (userResponce == "h")
                    {
                        max = computerguess;
                    }
                    else if (userResponce == "l")
                    {
                        min = computerguess;
                    }
                    computerguess = min + ((max - min) / 2);
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine($"AHA!! Your number was {userInput}, bow down before the might Mind Reader.");
        }
    }
}
