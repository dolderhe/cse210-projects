using System.IO;

class Journal
{
    public List<JournalEntry> _entries = new List<JournalEntry>();
    public List<string> used_prompts = new List<string>();

    

    public void DisplayJournal()
    {
        foreach(JournalEntry entry in _entries)
        {
            entry.DisplayJournalEntry();
            Console.WriteLine();
        }
        Console.Write("Press Enter After Reviewing Entries: ");
        Console.ReadLine();
    }

    public void CreateEntry()
    {
        JournalEntry entry = new JournalEntry();
        entry.CreateJournalEntry(used_prompts);
        _entries.Add(entry);
    }

    public void ReadFromFile(string filename)
    {
    string[] lines = System.IO.File.ReadAllLines(filename);
    _entries.Clear();

    foreach (string line in lines)
      {
       
        JournalEntry entry = new JournalEntry();
        string[] parts = line.Split("#");
        string date = parts[0];
        string question = parts[1];
        string entryText = parts[2];
        
		entry._date = date;
        entry._prompt = question;
        entry._response = entryText;

        _entries.Add(entry);

      }
    }

    

    public void WriteToFile(string filename) 
    { 
        using (StreamWriter outputFile = new StreamWriter(filename)) 
        { 
            foreach(JournalEntry entry in _entries) 
            { 
                outputFile.WriteLine(entry.CreateFileSystemString()); 
            }
        }
    }

    public void ClearFile(string filename)
    {   
        Console.Write("Are you sure you want to delete this file and subsequent journal entries? (y/n)\n> ");
        string user_input = Console.ReadLine();
        if (user_input.ToLower() == "y" || user_input.ToLower() == "yes")
        {
            _entries.Clear();
            File.WriteAllText(filename, "");
        }

    }
}