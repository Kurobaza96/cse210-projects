public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public Entry()
    {
    }

    public Entry(string date, string promptText, string entryText)
    {
        _date = date;
        _promptText = promptText;
        _entryText = entryText;
    }

    public void Display()
    {
        Console.WriteLine("----- My Journal -----");
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Response: {_entryText}");
        Console.WriteLine("----------------------");
        Console.WriteLine();
    }

    public string GetString()
    {
        return $"{_date}|{_promptText}|{_entryText}";
    }

    public void LoadFromString(string line)
    {
        string[] parts = line.Split('|');

        if (parts.Length >= 3)
        {
            _date = parts[0];
            _promptText = parts[1];
            _entryText = parts[2];
        }
    }
}