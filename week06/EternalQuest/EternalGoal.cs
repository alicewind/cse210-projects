public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, string points) : base(name, description, points)
    {

    }

    public override int RecordEvent()
    //Return the point value associated with recording the event.
    {
        return _points;
    }

    public override bool IsComplete()
    //return true if the goal is completed. 
    {
        return false;
    }

    public override string GetStringRepresentation()
    //Provide all of the details of a goal in a way that is easy to save to a file, and then load later.
    {
        return $"Eternal Goal, {_shortName}, {_description}, {_points}";
    }

}