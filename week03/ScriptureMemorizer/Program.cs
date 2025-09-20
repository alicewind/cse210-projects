//For extra credit I added a menu for the user to choose a scripture from a list.
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Enter the number of the scripture you would like to practice.");
        Console.WriteLine("1. John 10:16 \n2. James 1:5-6 \n3. 2 Nephi 2:27 \n4. D & C 82:10 \n5. Proverbs 3: 5-6 ");
        Console.Write("Scripture number: ");
        string choice = Console.ReadLine();

        string entry = "";

        Reference r1 = new Reference("John", 10, 16);
        Scripture s1 = new Scripture(r1, "And other sheep I have, which are not of this fold: them also I must bring, and they shall hear my voice; and there shall be one fold, and one shepherd.");

        Reference r2 = new Reference("James", 1, 5, 6);
        Scripture s2 = new Scripture(r2, "If any of you lack wisdom, let him ask of God, that giveth to all men liberally, and upbraideth not; and it shall be given him. But let him ask in faith, nothing wavering. For he that wavereth is like a wave of the sea driven with the wind and tossed.");

        Reference r3 = new Reference("2 Nephi", 2, 27);
        Scripture s3 = new Scripture(r3, "Wherefore, men are free according to the flesh; and all things are given them which are expedient unto man. And they are free to choose liberty and eternal life, through the great Mediator of all men, or to choose captivity and death, according to the captivity and power of the devil; for he seeketh that all men might be miserable like unto himself.");

        Reference r4 = new Reference("D & C", 82, 10);
        Scripture s4 = new Scripture(r4, "I, the Lord, am bound when ye do what I say; but when ye do not what I say, ye have no promise.");

        Reference r5 = new Reference("Proverbs", 3, 5, 6);
        Scripture s5 = new Scripture(r5, "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.");

        Scripture instance = s1;

        while (entry != "quit")
        {
            if (choice == "1")
            {
                instance = s1;
            }
            else if (choice == "2")
            {
                instance = s2;
            }
            else if (choice == "3")
            {
                instance = s3;
            }
            else if (choice == "4")
            {
                instance = s4;
            }
            else if (choice == "5")
            {
                instance = s5;
            }

            Console.Clear();
            string fullScripture = instance.GetDisplayText();
            Console.WriteLine(fullScripture);
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish: ");

            entry = Console.ReadLine();

            instance.HideRandomWords(3);

            if (instance.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(instance.GetDisplayText()); //print completely hidden scripture
                Console.WriteLine();
                entry = "quit";
            }
        }

    }
}