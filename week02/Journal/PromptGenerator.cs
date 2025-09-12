using System;
using System.Collections.Generic;

public class PromptGenerator
{

    public List<string> _prompts = new List<string>();

    public PromptGenerator()
    {
        _prompts.Add("What am I grateful for today?");
        _prompts.Add("What is the most interesting conversation I had today?");
        _prompts.Add("Who has been most on my mind today and why?");
        _prompts.Add("What did I do today to relax?");
        _prompts.Add("What was the most unique experience I had today?");
        _prompts.Add("What am I looking forward to this week or month?");
        _prompts.Add("What was my greatest accomplishment today or this week?");
        _prompts.Add("Who was the most interesting person I interacted with today?");
        _prompts.Add("What was the best part of my day?");
        _prompts.Add("How did I see the hand of the Lord in my life today?");
        _prompts.Add("What was the strongest emotion I felt today?");
        _prompts.Add("If I had one thing I could do over today, what would it be?");
    }

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int r = rand.Next(_prompts.Count);
        return _prompts[r];
    }
}