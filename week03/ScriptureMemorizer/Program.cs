using System;

class Program
{
    static void Main(string[] args)
    {
        string entry = "";

        Reference r1 = new Reference("John", 10, 16);
        Scripture s1 = new Scripture(r1, "And other sheep I have, which are not of this fold: them also I must bring, and they shall hear my voice; and there shall be one fold, and one shepherd.");

        while (entry != "quit")
        {
            Console.Clear();
            string fullScripture = s1.GetDisplayText();
            Console.WriteLine(fullScripture);
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish: ");

            entry = Console.ReadLine();

            s1.HideRandomWords(3);

            if (s1.IsCompletelyHidden())
            {
                entry = "quit";
            }
        }

    }
}