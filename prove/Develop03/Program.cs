using System;

class Program
{
    static void Main(string[] args)
    {
        // Word myWord = new Word("Secret");
        // myWord.Display();
        // myWord.Hide();
        // Console.WriteLine();
        // myWord.Display();

        ScriptureReference reference = new ScriptureReference("Moses", 1, 39);

        Scripture myScripture = new Scripture(reference,
            "For behold, this is my work and my glory to bring to pass the immortality and eternal life of man.");

        myScripture.ShowScripture();
        

    }
}