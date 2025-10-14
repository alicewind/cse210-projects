public class Swim : Activity
{
    private int _numberOfLaps;

    public Swim(string date, int activityLength, int numberOfLaps) : base(date, activityLength)
    {
        _numberOfLaps = numberOfLaps;
    }

    public override double GetDistance()
    {
        return _numberOfLaps * 50 / 1609.34;
    }
    public override double GetSpeed()
    {
        double distance = GetDistance();
        return (distance / _activityLength) * 60;
    }
    public override double GetPace()
    {
        double distance = GetDistance();
        return _activityLength / distance;
    }
    public override string GetActivityName()
    {
        return "Swimming";
    }
}
