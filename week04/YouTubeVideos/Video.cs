using System;
using System.Collections.Generic;

public class Video
{
    public string _title;
    public string _author;
    public int _videoLength;
    public List<Comment> _comments = new List<Comment>();

    public int CalcCommentListLength()
    {
        int numberOfComments = _comments.Count;
        return numberOfComments;
    }
    public void Display()
    {
        Console.WriteLine($"Title: {_title} \nAuthor: {_author} \nLength: {_videoLength} seconds");
        int numberOfComments = CalcCommentListLength();
        Console.WriteLine($"Number of Comments: {numberOfComments}");

        foreach (Comment comment in _comments)
        {
            comment.Display();
        }
        Console.WriteLine();
    }

}