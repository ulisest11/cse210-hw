using System;

public class Entry
{
    private string _date;
    private string _promptText;
    private string _entryText;

    public Entry(string prompt, string text)
    {
        _date = DateTime.Now.ToString("yyyy-MM-dd");
        _promptText = prompt;
        _entryText = text;
    }

    public Entry(string date, string prompt, string text)
    {
        _date = date;
        _promptText = prompt;
        _entryText = text;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Entry: {_entryText}\n");
    }

    public string ToFileString()
    {
        return $"{_date}|{_promptText}|{_entryText}";
    }

    public static Entry FromFileString(string line)
    {
        var parts = line.Split('|');
        if (parts.Length == 3)
        {
            return new Entry(parts[0], parts[1], parts[2]);
        }
        return null;
    }
}
