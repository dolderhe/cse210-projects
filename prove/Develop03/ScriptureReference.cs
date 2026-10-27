class ScriptureReference
{

    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;

    public ScriptureReference(string book, int chapter, int startVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = 0;
    }
    public ScriptureReference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }
    public string GetScriptureReference()
    {
        if (_endVerse != 0)
        {
            string reference = $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
            return reference;
        }
        else
        {
            string reference = $"{_book} {_chapter}:{_startVerse}"; 
            return reference;
        }
    }

    public void DisplayReference()
    {
        Console.WriteLine(GetScriptureReference());
    }
    

}