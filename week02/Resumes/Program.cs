using System;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Hewlitt Packard";
        job1._jobTitle = "Software Developer";
        job1._startYear = 2021;
        job1._endYear = 2025;

        Job job2 = new Job();
        job2._company = "Google";
        job2._jobTitle = "Programmer";
        job2._startYear = 2019;
        job2._endYear = 2021;

        Resume resume = new Resume();
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);
        resume._name = "Howard Johnson";

        resume.Display();

    }
}