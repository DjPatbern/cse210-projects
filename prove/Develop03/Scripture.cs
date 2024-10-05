using System;
using System.Collections.Generic;
using System.Linq;

class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void Display()
    {
        Console.WriteLine(_reference.GetDisplayText());

        foreach (Word word in _words)
        {
            Console.Write(word.GetDisplayText() + " ");
        }
    }

    public void HideRandomWords(int numberOfWordsToHide)
    {
        Random random = new Random();
        var wordsToHide = _words.Where(word => !word.IsHidden).OrderBy(word => random.Next()).Take(numberOfWordsToHide).ToList();

        foreach (var word in wordsToHide)
        {
            word.Hide();
        }
    }

    public bool AreAllWordsHidden()
    {
        return _words.All(word => word.IsHidden);
    }
}
