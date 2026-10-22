class Scripture
{
    private List<Word> _words;

    // TODO - add scripture reference

    public Scripture(string bookName, int chapter, int verse, string text)
    {
        _words = ConvertToWordList(text);
    }
    public Scripture(string bookName, int chapter, int startVerse, int endVerse, string text)
    {
        // todo
    }
// TODO add constructor for ScriptureReference
//  public Scripture(ScriptureReference)
//  {

//  }

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

}