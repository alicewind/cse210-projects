public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description) : base(name, description)
    {

    }
    public void Run()
    {
        DisplayStartingMessage();
        Console.Clear();
        Console.WriteLine("Get ready... ");
        ShowSpinner(6);

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine();
            Console.Write("Breathe in... ");
            ShowCountDown(5);
            Console.WriteLine();
            Console.Write("Now breathe out... ");
            ShowCountDown(5);
            Console.WriteLine();
        }

        DisplayEndingMessage();
        ShowSpinner(7);
    }
}