using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Run run1 = new Run("9 Nov 2025", 30, 3.5);
        activities.Add(run1);

        Cycle cycle1 = new Cycle("10 Nov 2025", 45, 16);
        activities.Add(cycle1);

        Swim swim1 = new Swim("12 Nov 2025", 19, 16);
        activities.Add(swim1);

        Run run2 = new Run("14 Nov 2025", 20, 2.1);
        activities.Add(run2);

        Console.Clear();
        foreach (Activity a in activities)
        {
            a.GetSummary();
        }

    }
}