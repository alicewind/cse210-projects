using System;

public class Word //Keeps track of a single word and whether it is shown or hidden.
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    // accept the text of a word and save it as an attribute and set initial visibility of the word
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }
    public void Show()
    {
        _isHidden = false;
    }
    public bool IsHidden()
    {
        return _isHidden; //details need to be added
    }
    public string GetDisplayText()
    {
        if (_isHidden)
        {
            return new string('_', _text.Length);
        }
        else
        {
            return _text;
        }
    }
}