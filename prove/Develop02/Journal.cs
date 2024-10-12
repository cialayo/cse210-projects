using System.IO;
public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public Journal()
    {
    }
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
    public void DisplayAll()
    {
        foreach (Entry _entry in _entries)
        {
            _entry.Display();
        }
    }
    public void SaveToFile(string fileName)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry _entry in _entries)
            {
                outputFile.WriteLine($"{_entry._date},{_entry._promptText},{_entry._entryText}");
            }
        }

    }
    public void LoadFromFile(string file)
    {
        _entries.Clear();
        string[] lines = System.IO.File.ReadAllLines(file);
        foreach (string line in lines)
        {
            string[] words = line.Split(",");
            Entry newEntry = new Entry();
            newEntry._date = words[0];
            newEntry._promptText = words[1];
            newEntry._entryText = words[2];

            _entries.Add(newEntry);
        }
    }

}