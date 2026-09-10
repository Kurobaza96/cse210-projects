public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries found in the journal.");
            return;
        }
        Console.WriteLine("----- My Journal -----");
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
        Console.WriteLine("----------------------");
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine(entry.GetString());
            }
        }

        Console.WriteLine("Entry saved to file successfully.");
    }

    public void LoadFromFile(string filename)
    {
        _entries.Clear();

        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            Entry entry = new Entry();
            entry.LoadFromString(line);
            _entries.Add(entry);
        }

        Console.WriteLine("Entries loaded from file successfully.");
    }
}