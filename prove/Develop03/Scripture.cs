class Scripture
{
    private List<Word> _words;

    private ScriptureReference _reference;

    private Random _random = new Random();

    // TODO - add scripture reference

    public Scripture(string bookName, int chapter, int verse, string text)
    {
        _words = ConvertToWordList(text);
        _reference = new ScriptureReference(bookName, chapter, verse);
    }
    public Scripture(string bookName, int chapter, int startVerse, int endVerse, string text)
    {
        _words = ConvertToWordList(text);
        _reference = new ScriptureReference(bookName, chapter, startVerse, endVerse);
    }
// TODO add constructor for ScriptureReference
    public Scripture(ScriptureReference reference, string text)
    {
        _reference = reference;
        _words = ConvertToWordList(text);
    }

/*
* ConvertToWordList() - this method will receive a string parameter
* Which is a paragraph of text. It will split that text into words and add those words
* to a List<word> and return that list.
*
*/


    public void ShowScripture()
    {
        foreach(Word word in _words){
            word.Display();
        }
    }

    private List<Word> ConvertToWordList(string text)
    {
        List<Word> tempWordList = new List<Word>();

        string[] tempWords = text.Split(' ');

        foreach (string word in tempWords)
        {
            Word tempWord = new Word(word);
            tempWordList.Add(tempWord);
        }

        return tempWordList;
    }

    public int HideWords(int index, int i)
        {
            if (!_words[index].isHidden())
                {
                _words[index].Hide();
                return i;
                }
            else
                {
                return i - 1;
                }
            }
    public void HideSomeWords()
    {
        // Choose from visible words so every turn hides new words.
        List<Word> visibleWords = new List<Word>();

        foreach (Word word in _words)
        {
            if (!word.isHidden())
            {
                visibleWords.Add(word);
            }
        }
        
        // Hide three per turn, or the smaller number remaining.
        int numberToHide = Math.Min(3, visibleWords.Count);

        for (int i = 0; i < numberToHide; i++)
        {
            int index = _random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }
    }
        public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.isHidden())
            {
                return false;
            }
        }

        return true;
    }

}

