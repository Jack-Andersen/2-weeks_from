using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guessing_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            int winNum = r.Next(0, 10);
            int guessCount = 0;

            bool win = false;

            do
            {
                Console.WriteLine("Gusss a number inbetween 0 and 10");
                string answer = Console.ReadLine();

                int guess = int.Parse(answer);
                ++guessCount;

                if (guess > winNum)
                {
                    Console.WriteLine("To high.. guess lover...");
                }

                else if (guess < winNum)
                {
                    Console.WriteLine("To low.. guess higer...");
                }

                else if (guess == winNum)
                {
                    
                    Console.WriteLine("You Win! you guessed " + guessCount + " times");
                    win = true;
                }

                Console.WriteLine();

            } while (win == false);

            Console.WriteLine("Thank you for playing the game");
            Console.Write("press any key to exit");
            Console.ReadKey(true);
            
        }
    }
}
