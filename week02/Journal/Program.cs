using System;

using System.Net;

class Program
{
    static void Main(string[] args)
    {

        string choice = "";

        Journal journal = new Journal();

        Console.WriteLine("Welcome to the journal program!");

        while (choice != "5")
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write \n2. Display \n3. Load \n4. Save \n5. Quit ");
            Console.Write("What would you like to do? ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                Entry entry = new Entry();
                PromptGenerator prompt = new PromptGenerator();
                string _promptText = prompt.GetRandomPrompt();

                Console.WriteLine($"{_promptText}");
                Console.Write("> ");
                string userEntry = Console.ReadLine();

                entry._entryText = userEntry;
                entry._promptText = _promptText;
                DateTime now = DateTime.Now;
                entry._date = now.ToShortDateString();

                journal.AddEntry(entry);
                //Console.WriteLine(now);

            }
            else if (choice == "2")
            {
                journal.DisplayAll();
            }
            else if (choice == "3")
            {
                Console.WriteLine("What is the filename?");
                journal._filename = Console.ReadLine();
                journal.LoadFromFile();
            }
            else if (choice == "4")
            {
                Console.WriteLine("What is the filename?");
                journal._filename = Console.ReadLine();
                journal.SaveToFile();
            }
        }
    }
}