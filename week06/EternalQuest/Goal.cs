public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;

    public Goal(string name, string description, string points)
    {
        _shortName = name;
        _description = description;
        _points = int.Parse(points);
    }

    public abstract int RecordEvent();

    public abstract bool IsComplete();

    public virtual string GetDetailsString()
    //This method should return the details of a goal that could be shown in a list. It should include the checkbox, the short name, and description.
    {
        if (!IsComplete())
        {
            return $"[ ] {_shortName} ({_description})";
        }
        else
        {
            return $"[X] {_shortName} ({_description})";
        }
    }

    public abstract string GetStringRepresentation();

}