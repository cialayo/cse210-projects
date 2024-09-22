using System;

class Program
{
    static void Main(string[] args)
    {
        // Guess My Number game
        Console.Write("What is the magic number? ");
        string magicNumberInText = Console.ReadLine();
        int magicNumber = int.Parse(magicNumberInText);

        Console.Write("What is your guess? ");
        string guessInText = Console.ReadLine();
        int guess = int.Parse(guessInText);

        if (magicNumber == guess)
        {
            Console.WriteLine("You guessed it!");
        }
        else if (magicNumber > guess)
        {
            Console.WriteLine("Higher");
        }
        else
        {
            Console.WriteLine("Lower");
        }
    }
}