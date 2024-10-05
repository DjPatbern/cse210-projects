using System;

class Reference
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;

    public Reference(string book, int chapter, int startVerse, int endVerse = 0)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse == 0 ? startVerse : endVerse;
    }

    public string GetDisplayText()
    {
        return $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
    }
}
