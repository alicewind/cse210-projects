public class Cycle : Activity
{
    private int _speed;

    public Cycle(string date, int activityLength, int speed) : base(date, activityLength)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return (_speed * _activityLength) / 60;
    }
    public override double GetSpeed()
    {
        return _speed;
    }
    public override double GetPace()
    {
        return 60 / _speed;
    }
    public override string GetActivityName()
    {
        return "Indoor Cycling";
    }
}
