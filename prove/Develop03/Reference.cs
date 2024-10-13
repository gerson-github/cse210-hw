using System;
public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int? _endVerse;
    private int? _startVerse;
    

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = null;
        _startVerse = null;
    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _endVerse = endVerse;
        _startVerse = startVerse;
    }


    public string GetDisplayText() 
    {
        string returnText = _endVerse.HasValue ? $"{_book} {_chapter}:{_startVerse}-{_endVerse}" : $"{_book} {_chapter}:{_verse}";
        return returnText;
      
    }

    //getters
    public string Book => _book;
    public int chapter => _chapter;
    public int Verse => _verse;
    public int? StartVerse => _startVerse;
    public int? EndVerse => _endVerse;


}