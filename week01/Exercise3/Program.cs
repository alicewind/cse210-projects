using System;

class Program
{
    static void Main(string[] args)
    {
        int numberGuess = 11111;
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);

        while (numberGuess != number)
        {
            Console.Write("What is your guess? ");
            string guess = Console.ReadLine();
            numberGuess = int.Parse(guess);

            if (numberGuess == number)
            {
                Console.WriteLine("You guessed it!");
            }
            else if (numberGuess >= number)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("Higher");
            }

        }
    }
}