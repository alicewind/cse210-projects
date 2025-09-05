using System.Collections.Generic;
using System.Globalization;
class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int entry = -1;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (entry != 0)
        {
            Console.Write("Enter number: ");
            string response = Console.ReadLine();
            entry = int.Parse(response);

            if (entry != 0)
            {
                numbers.Add(entry);
            }
        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");
        int numberCount = numbers.Count;
        float average = ((float)sum) / numberCount;
        Console.WriteLine($"The average is: {average}");

        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The largest number is: {max}");
    }

}