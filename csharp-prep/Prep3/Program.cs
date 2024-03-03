using System;

class Program
{
    static void Main(string[] args)
    {
        bool PlayAgain = true;
        

        while(PlayAgain) {

            bool guess = false;
            Console.WriteLine("What is the magic number? ");
            int magicNum = int.Parse(Console.ReadLine());
            int count = 0;

            while(guess == false) {
                Console.WriteLine("What is your guess?");
                int guessNum = int.Parse(Console.ReadLine());
                if (guessNum == magicNum) {
                    Console.WriteLine($"You guessed it in {count} tries!");
                    guess = true;
                } else if (guessNum < magicNum) {
                    Console.WriteLine("Higher");
                    count++;
                } else {
                    Console.WriteLine("Lower");
                    count++;
                }
            }

            Console.WriteLine("Would you like to play again? (Enter 'y' or 'n')");
            string play = Console.ReadLine();
            if (play.ToLower() == "n") {
                PlayAgain = false;
            }
        }

        Console.WriteLine("Ok! Thanks for playing!");
    }
}