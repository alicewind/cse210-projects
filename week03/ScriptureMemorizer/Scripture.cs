using System;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {

    }

    public void HideRandomWords(int numberToHide)
    {

    }
    public string GetDisplayText()
    {
        string displayText = ""; //this is a shell to fill in later
        return displayText;
    }
    public bool IsCompletelyHidden()
    {
        return true; //details need to be added
    }

}
