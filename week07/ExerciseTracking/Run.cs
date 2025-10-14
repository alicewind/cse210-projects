public class Run : Activity
{
    private double _distance;

    //public SimpleGoal(string name, string description, string points) : base(name, description, points)
    public Run(string date, int activityLength, double distance) : base(date, activityLength)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }
    public override double GetSpeed()
    {
        return (_distance / _activityLength) * 60;
    }
    public override double GetPace()
    {
        return _activityLength / _distance;
    }
    public override string GetActivityName()
    {
        return "Running";
    }
}