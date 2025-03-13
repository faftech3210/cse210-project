using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.IO;
using System.Net.Mail;

public class Journal
{
    public List<Entry> _entreies = new List<Entry>();
    public void AddEntry(string prompt, string response)
    {
        string date = DateTime.Now.ToString("yyyy-MM-dd");
        Entry newEntry = new Entry(date,prompt,response);
        _entreies.Add(newEntry);
    }

    public void Display()
    {
        foreach(Entry entry in _entreies)
        {
            entry.display();
        }
    }

    public void SaveToFile(string fileName)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        foreach (Entry entry in _entreies)
        {
            writer.WriteLine($"{entry._date}|{entry._prompt}|{entry._response}");
        }
        Console.WriteLine($"Journal successfully saved to {fileName}");
    }
    
    public void LoadFromFile(string fileName)
    {
        _entreies.Clear();
        string[] lines = File.ReadAllLines(fileName);
        foreach (string line in lines)
        {
            string[] parts = line.Split('|');
            if (parts.Length == 3)
            {
                Entry entry = new Entry(parts[0], parts[1], parts[2]);
                _entreies.Add(entry);
            }
        }
        Console.WriteLine($"Journal is loaded from {fileName}");
    }
}