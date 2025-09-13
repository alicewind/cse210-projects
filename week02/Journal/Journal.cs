using System.Collections.Generic;
using System.IO;

public class Journal
{
    public string _filename;
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
            Console.WriteLine("");
        }
    }
    public void SaveToFile()
    {
        using (StreamWriter outputFile = new StreamWriter(_filename))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}~~{entry._promptText}~~{entry._entryText}");
            }
        }
    }
    public void LoadFromFile()
    {
        string[] lines = System.IO.File.ReadAllLines(_filename);

        foreach (string line in lines)
        {
            string[] section = line.Split("~~");
            Entry entry = new Entry
            {
                _date = section[0],
                _promptText = section[1],
                _entryText = section[2],
            };
            _entries.Add(entry);
        }

    }
}