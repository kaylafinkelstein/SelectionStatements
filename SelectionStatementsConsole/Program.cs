using System;

namespace SelectionStatementsConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int favNumber = 10;
            Console.WriteLine("Try to guess my favorite number");
            int userGuess = int.Parse(Console.ReadLine());

            if (userGuess < favNumber)
            {
                Console.WriteLine("Too Low !");
            }
            else if  (userGuess > favNumber)
            {
                Console.WriteLine("Too High!");
            }
            else 
            {
                Console.WriteLine("Nevermind");
            }
        }
    }
}
