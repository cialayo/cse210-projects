using System;

class Program
{
    static void Main(string[] args)
    {
        // Guess My Number game
        
        //Console.Write("What is the magic number? ");
        //string magicNumberInText = Console.ReadLine();
        //int magicNumber = int.Parse(magicNumberInText);

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guess = 0;

        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            string guessInText = Console.ReadLine();
            guess = int.Parse(guessInText);

            if (magicNumber > guess)
            {
            Console.WriteLine("Higher");
            }
            else if (magicNumber < guess)
            {
            Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}