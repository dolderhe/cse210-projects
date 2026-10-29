class Scripture
{
    private List<Word> _words;

    private ScriptureReference _reference;

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
        // TODO add code to hide multiple words
        Random random = new Random();

        int listLength = _words.Count;

        Console.Write("");
        string input = Console.ReadLine();
        int visibleWords = 0;

        foreach (Word word in _words)
        {
            if (!word.isHidden())
            {
                visibleWords++;
                
            }
        }
        
        if (visibleWords > 6)
        {
            for(int i = 1; i <= 3 ; i +=1){
            int index = random.Next(0, listLength);
            i = HideWords(index, i);
            }
        }
        else
        {
            int i = 0;
            int index = random.Next(0, listLength);
            HideWords(index, i);
        }
    }

}