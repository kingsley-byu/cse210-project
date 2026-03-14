using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
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
        } 
    }
    
    public void saveToFile(string file)
    {
        using (StreamWriter saveFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                saveFile.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}");
            }
        }
    }

    public void loadFromFile(string file)
    {
        string lines = System.IO.File.ReadAllLines(file);
        _entries.Clear();
    }
    

}