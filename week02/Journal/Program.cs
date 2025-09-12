using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {

        string choice = "";

        Console.WriteLine("Welcome to the journal program!");

        while (choice != "5")
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write \n2. Display \n3. Load \n4. Save \n5. Quit ");
            Console.Write("What would you like to do? ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                PromptGenerator prompt = new PromptGenerator();
                string _promptText = prompt.GetRandomPrompt();
                Console.WriteLine($"{_promptText}");
                Console.Write("> ");
                string newEntry = Console.ReadLine();
            }
            else if (choice == "2")
            {

            }
        }
    }
}