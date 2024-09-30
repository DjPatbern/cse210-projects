using System;

public class Entry
{
    public string Date { get; private set; }
    public string Prompt { get; private set; }
    public string Text { get; private set; }

    public Entry(string date, string prompt, string text)
    {
        Date = date;
        Prompt = prompt;
        Text = text;
    }

    public override string ToString()
    {
        return $"{Date}|{Prompt}|{Text}";
    }
}
