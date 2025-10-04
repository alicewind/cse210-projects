using System.Runtime.CompilerServices;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>();

    public ListingActivity(string name, string description) : base(name, description)
    {
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.Clear();
        Console.WriteLine("Get ready... ");
        ShowSpinner(6);
        Console.WriteLine();

        Console.WriteLine("List as many responses you can to the following prompt: ");
        GetRandomPrompt();
        Console.Write("You may begin in: ");
        ShowCountDown(7);
        Console.WriteLine();

        GetListFromUser();
        Console.WriteLine($"You listed {_count} items!");

        DisplayEndingMessage();
        ShowSpinner(7);
    }
    public void GetRandomPrompt()
    {
        Random rand = new Random();
        int r = rand.Next(_prompts.Count);
        Console.WriteLine($"---- {_prompts[r]} ----");
    }
    public List<string> GetListFromUser()
    {
        List<string> responses = new List<string>();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            responses.Add(Console.ReadLine());
        }
        int count = responses.Count();
        _count = count;
        return responses;
    }
}
