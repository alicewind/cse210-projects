public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, string points) : base(name, description, points)
    {

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

    public override string GetDetailsString()//program is requiring this, not sure why
    {
        throw new NotImplementedException();
    }
}