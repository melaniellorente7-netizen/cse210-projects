public class Journal()
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

    public void SaveToFile(string file)
    {
        using (StreamWriter ouputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                ouputFile.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}");
            }
        }
    }

    public void LoadFromFile(string file)
    {
        _entries.Clear();

        string[] lines = System.IO.File.ReadAllLines(file);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            Entry newEntry = new Entry();
            newEntry._date = parts[0];
            newEntry._promptText = parts[1];
            newEntry._entryText = parts[2];

            AddEntry(newEntry);
        }
    }

    public void SearchEntries (string keyword)
    {
        bool foundAny = false;
        foreach (Entry entry in _entries)
        {
            if (entry._entryText.ToLower().Contains(keyword.ToLower()))
            {
                entry.Display();
                foundAny = true;
            }
        }
        if (!foundAny)
        {
            Console.WriteLine("No entries found containing that keyword");
        }
    }
}