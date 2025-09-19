using System;

public class Reference //Keeps track of the book, chapter, and verse information.
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    string referenceText = "";

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        referenceText = $"{_book} {_chapter}:{_verse}";
    }
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
        referenceText = $"{_book} {_chapter}:{_verse}-{_endVerse}";
    }
    public string GetDisplayText()
    {
        return referenceText;
    }
}