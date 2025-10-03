public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();

    public ReflectingActivity(string name, string description) : base(name, description)
    {
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");

        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.Clear();
        Console.WriteLine("Get ready... ");
        ShowSpinner(6);

        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        string prompt = GetRandomPrompt();
        DisplayPrompt(prompt);
        Console.WriteLine();

        Console.WriteLine($"When you have something in mind, press Enter to continue.");
        string enterText = Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(6);
        Console.Clear();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            string question = GetRandomQuestion();
            DisplayQuestion(question);
            Thread.Sleep(7000);
        }

        DisplayEndingMessage();
        ShowSpinner(7);
    }
    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int r = rand.Next(_prompts.Count);
        return _prompts[r];
    }
    public string GetRandomQuestion()
    {
        Random rand = new Random();
        int r = rand.Next(_questions.Count);
        return _questions[r];
    }
    public void DisplayPrompt(string prompt)
    {
        Console.WriteLine($"---- {prompt} ----");
    }
    public void DisplayQuestion(string question)
    {
        Console.WriteLine($"{question}");
    }
}