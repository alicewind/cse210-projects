public abstract class Activity
{
    protected string _date;
    protected float _activityLength;

    public Activity(string date, int activityLength)
    {
        _date = date;
        _activityLength = activityLength;
    }

    public abstract double GetDistance();

    public abstract double GetSpeed();

    public abstract double GetPace();

    public abstract string GetActivityName();

    public void GetSummary()
    {
        Console.WriteLine($"* {_date} {GetActivityName()} ({_activityLength} min)- Distance {GetDistance():0.00} miles, Speed {GetSpeed():0.00} mph, Pace {GetPace():0.00} min per mile");
    }

}