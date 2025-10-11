using System.Runtime.CompilerServices;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    string goalType = "";

    public GoalManager()
    {
        _score = 0;
    }

    public void Start()
    //This is the "main" function for this class. It is called by Program.cs, and then runs the menu loop.
    {
        string userChoice = "";

        while (userChoice != "6")
        {
            DisplayPlayerInfo();
            Console.WriteLine();
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("    1. Create New Goal \n    2. List Goals \n    3. Save Goals \n    4. Load Goals \n    5. Record Event \n    6. Quit");
            Console.Write("Select a choice from the menu: ");
            userChoice = Console.ReadLine();

            if (userChoice == "1")
            {
                CreateGoal();
            }
            if (userChoice == "2")
            {
                ListGoalDetails();
            }
            if (userChoice == "3")
            {
                SaveGoals();
            }
            if (userChoice == "4")
            {
                LoadGoals();
            }
            if (userChoice == "5")
            {
                RecordEvent();
            }
        }
    }

    public void DisplayPlayerInfo()
    //Displays the players current score.
    {

        Console.WriteLine();
        Console.WriteLine($"You have {_score} points."); //Add _score coding when ready
    }

    public void ListGoalNames()
    //Lists the names of each of the goals.
    {

    }

    public void ListGoalDetails()
    //Lists the details of each goal (including the checkbox of whether it is complete).
    {
        while (_goals.Count == 0)
        {
            Console.WriteLine("You have not specified any goals yet.");
        }
        Console.WriteLine("The goals are: ");
        int count = 1;
        foreach (Goal g in _goals)
        {
            Console.WriteLine($"{count}. {g.GetDetailsString()}");
            count++;
        }
    }

    public void CreateGoal()
    //Asks the user for the information about a new goal. Then, creates the goal and adds it to the list.
    {
        Console.WriteLine("The types of Goals are: ");
        Console.WriteLine("    1. Simple Goal \n    2. Eternal Goal \n    3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string userGoalChoice = Console.ReadLine();
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        string points = Console.ReadLine();


        if (userGoalChoice == "1")
        {
            SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
            _goals.Add(simpleGoal);
            goalType = "Simple Goal";
        }
        else if (userGoalChoice == "2")
        {
            EternalGoal eternalGoal = new EternalGoal(name, description, points);
            _goals.Add(eternalGoal);
            goalType = "Eternal Goal";
        }
        else if (userGoalChoice == "3")
        {
            Console.WriteLine("How many times does this goal need to be accomplished for a bonus? ");
            string userTarget = Console.ReadLine();
            int target = int.Parse(userTarget);
            Console.WriteLine("What is the bonus for accomplishing it that many times? ");
            string userBonus = Console.ReadLine();
            int bonus = int.Parse(userBonus);

            ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, target, bonus);
            _goals.Add(checklistGoal);
            goalType = "Checklist Goal";
        }

    }

    public void RecordEvent()
    //Asks the user which goal they have done and then records the event by calling the RecordEvent method on that goal.
    {
        ListGoalDetails();
        Console.Write("Which goal did you accomplish? ");
        string entry = Console.ReadLine();
        int goalNumber = int.Parse(entry);
        int earnedPoints = _goals[goalNumber - 1].RecordEvent();
        _score += earnedPoints;
    }

    public void SaveGoals()
    //Saves the list of goals to a file.
    {

    }

    public void LoadGoals()
    //Loads the list of goals from a file.
    {

    }
}