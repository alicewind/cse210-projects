public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, string points) : base(name, description, points)
    {
        _isComplete = false;
    }

    public override int RecordEvent()
    //Marking goal complete. Return the point value associated with recording the event.
    {
        _isComplete = true;
        return _points;
    }

    public override bool IsComplete()
    //return true if the goal is completed. 
    {
        if (_isComplete == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public override string GetStringRepresentation()
    //Provide all of the details of a goal in a way that is easy to save to a file, and then load later.
    {
        return $"Simple Goal, {_shortName}, {_description}, {_points}, {_isComplete}";
    }

}
