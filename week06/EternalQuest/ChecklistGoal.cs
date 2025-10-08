public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    public ChecklistGoal(string name, string description, string points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        throw new NotImplementedException();//nope
    }

    public override bool IsComplete()
    {
        throw new NotImplementedException();//nope
    }

    public override string GetStringRepresentation()
    {
        throw new NotImplementedException();//nope
    }

    public override string GetDetailsString()
    {
        throw new NotImplementedException();//nope
    }

}

