using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
//Keeps track of both the reference and the text of the scripture. 
// Can hide words and get the rendered display of the text.
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    //pass in string of scripture text, create the list, and split up the words in the string
    //to create Word objects for each one and put them in the list.
    {
        _reference = reference;

        string[] wordString = text.Split(" ");
        foreach (string w in wordString)
        {
            Word word = new Word(w);
            _words.Add(word);
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        List<Word> shownWords = _words.Where(w => !w.IsHidden()).ToList();
        if (shownWords.Count == 0) return;

        List<Word> randomWords = shownWords.OrderBy(x => random.Next()).Take(numberToHide).ToList();
        foreach (Word randomWord in randomWords)
        {
            randomWord.Hide();
        }
    }
    public string GetDisplayText()
    //The "display text" refers to the text with some words shown normally, 
    // and some replaced by underscores.
    {
        string scriptureText = $"{_reference.GetDisplayText()} ";
        foreach (Word word in _words)
        {
            scriptureText += word.GetDisplayText() + " ";
        }

        return scriptureText;
    }
    public bool IsCompletelyHidden()
    //checks if the scripture is completely hidden so that you know when to end the program.
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}
