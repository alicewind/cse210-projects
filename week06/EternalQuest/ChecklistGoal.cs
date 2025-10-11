public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    public ChecklistGoal(string name, string description, string points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }

    public override int RecordEvent()
    //Adding to the number of times a checklist goal has been completed. Return the point value associated with recording the event (it may contain a bonus in some cases if a checklist goal was just finished).
    {
        _amountCompleted++;
        if (!IsComplete())
        {
            return _points;
        }
        else
        {
            return _points + _bonus;
        }
    }

    public override bool IsComplete()
    //return true if the goal is completed. 
    {
        if (_amountCompleted >= _target)
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
        return $"Checklist Goal: {_shortName}, {_description}, {_points}, {_bonus}, {_target}, {_amountCompleted}";
    }

    public override string GetDetailsString()
    //This method should return the details of a goal that could be shown in a list. It should include the checkbox, the short name, and description. In the case of the ChecklistGoal class, it should be overridden to shown the number of times the goal has been accomplished so far.
    {
        if (!IsComplete())
        {
            return $"[ ] {_shortName} ({_description} -- Currently Completed {_amountCompleted}/{_target})";
        }
        else
        {
            return $"[X] {_shortName} ({_description}) -- Currently Completed {_amountCompleted}/{_target}";
        }
    }
}

