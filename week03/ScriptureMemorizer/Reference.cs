using System;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endverse;

    public Reference(string book, int chapter, int verse)
    {

    }
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {

    }

    public string GetDisplayText()
    {
        string displayText = ""; //this is a shell to fill in later
        return displayText;
    }
}