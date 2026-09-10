public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;
    public string _mood;

    public Entry()
    {
    }

    public Entry(string date, string promptText, string entryText, string mood)
    {
        _date = date;
        _promptText = promptText;
        _entryText = entryText;
        _mood = mood;
    }

    public void Display()
    {
        
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Response: {_entryText}");
        Console.WriteLine($"Mood: {_mood}");
        Console.WriteLine();
    }

    public string GetString()
    {
        return $"{_date}|{_promptText}|{_entryText}|{_mood}";
    }

    public void LoadFromString(string line)
    {
        string[] parts = line.Split('|');

        if (parts.Length >= 4)
        {
            _date = parts[0];
            _promptText = parts[1];
            _entryText = parts[2];
            _mood = parts[3];
        }
    }
}