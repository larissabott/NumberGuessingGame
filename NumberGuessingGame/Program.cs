using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            int winNum = r.Next(0, 100);

            bool win = false;

            do
            {
                Console.Write("Guess a number in betwixed 0 and 100: ");
                string s = Console.ReadLine();
                int i = int.Parse(s);
                if (i > winNum)
                {
                    Console.WriteLine("To high! Guess again... lower");
                }
                else if (i < winNum)
                {
                    Console.WriteLine("To low! Guess again... higher");
                }
                else if (i == winNum)
                {
                    Console.WriteLine("ya guessed it, you win!!!");
                    win = true;
                }

            }while (win == false);

            Console.WriteLine("Thanks for playing :)");
            Console.Write("PRESS ANY KEY TO FINISH");
            Console.ReadKey(true);
        }
    }
}
