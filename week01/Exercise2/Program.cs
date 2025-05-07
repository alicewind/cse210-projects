using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your percentage? ");
        string userPercentage = Console.ReadLine();

        int percentage = int.Parse(userPercentage);
        string letter = "";

        if (percentage >= 90)
        {
            letter = "A";
        }
        else if (percentage < 90 && percentage >= 80)
        {
            letter = "B";
        }
        else if (percentage < 80 && percentage >= 70)
        {
            letter = "C";
        }
        else if (percentage < 70 && percentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is {letter}");

        if (percentage >= 70)
        {
            Console.WriteLine("Congratulations, you have passed the class! ");
        }
        else
        {
            Console.WriteLine("Sorry, you have not passed the class. Better luck next time!");
        }

    }
}