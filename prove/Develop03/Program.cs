using System;

class Program
{
    static void Main(string[] args)
   {
    ScriptureReference reference = new ScriptureReference("Moses", 1, 39);
    Scripture myScripture = new Scripture(reference,
        "For behold, this is my work and my glory to bring to pass the immortality and eternal life of man.");

    Console.Clear();
    string user_input = "just";

    while (!user_input.Equals("quit") && !myScripture.IsCompletelyHidden())
    {
        
        reference.DisplayReference();
        myScripture.ShowScripture();

        Console.WriteLine();
        Console.WriteLine("Press Enter to continue or type 'quit' to finish:");
        user_input = Console.ReadLine();
        if (!user_input.Equals("quit"))
            {
                Console.Clear();
                myScripture.HideSomeWords();

            }

    }
    Console.WriteLine("Well Done!");
    }
}