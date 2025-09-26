using System;

public class Comment
{
    public string _commenterName;
    public string _text;

    public void Display()
    {
        Console.WriteLine($"Commenter Name: {_commenterName} Comment Text: {_text} ");
    }
}