class JournalEntry
{
    
    public string _date;
    public string _prompt;
    public string _response;


    public void DisplayJournalEntry()
    {
        Console.WriteLine($"{_date}, {_prompt}");
        Console.WriteLine(_response);
    }

    public void CreateJournalEntry(List<string>used_prompts)
    {
        Random random = new Random();
        
        string [] prompts =
        {
            "How was your day?",
            "Talk about someone you met:",
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };
        
        do
        {

        _date = DateTime.Now.ToString();
        _prompt = prompts[random.Next(prompts.Length)];
        
        if (used_prompts.Count == prompts.Length)
            {
                used_prompts.Clear();
            }
             
        } while (used_prompts.Contains(_prompt));
        
        used_prompts.Add(_prompt);
        Console.Write($"{_prompt} ");
        _response = Console.ReadLine();
    }
    
    public string CreateFileSystemString() 
    { 
        string outputString = ""; 
        outputString = $"{_date}#{_prompt}#{_response}"; 
        return outputString; 
    }
}