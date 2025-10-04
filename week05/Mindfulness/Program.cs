using System;

class Program
{
    static void Main(string[] args)
    {
        int menuNumber = 0;

        while (menuNumber != 4)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("    1. Start breathing activity \n    2. Start reflecting activity \n    3. Start listing activity \n    4. Quit ");
            Console.Write("Select a choice from the menu: ");
            string menuChoice = Console.ReadLine();
            menuNumber = int.Parse(menuChoice);

            if (menuNumber == 1)
            {
                BreathingActivity activity1 = new BreathingActivity("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
                activity1.Run();
            }

            else if (menuNumber == 2)
            {
                ReflectingActivity activity2 = new ReflectingActivity("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                activity2.Run();
            }

            else if (menuNumber == 3)
            {
                ListingActivity activity3 = new ListingActivity("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                activity3.Run();
            }
        }
    }
}