class Goals
{
    private List<BaseGoal> _goalList;
    private string _filename;
    private int _totalScore;

    public Goals()
    {
        _goalList = new List<BaseGoal>();
    }

    public void DisplayScore()
    {
        Console.WriteLine($"You have {_totalScore} points.");
    }

    public void AddGoal(BaseGoal Goal)
    {
        _goalList.Add(Goal);
    }

    public void LoadGoals()
    {
        ObtainFileName("Where are your goals saved? ");
        string[] lines = System.IO.File.ReadAllLines(_filename);

        _goalList.Clear();

        _totalScore = int.Parse(lines[0]);

        for(int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split(",");
            switch (parts[0])
            {
                case "SimpleGoal":
                    SimpleGoal simpleGoal = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4]), parts[0]);
                    AddGoal(simpleGoal);
                    break;
                case "EternalGoal":
                    EternalGoal eternalGoal = new EternalGoal(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4]), parts[0]);
                    AddGoal(eternalGoal);
                    break;
                case "ChecklistGoal":
                    ChecklistGoal checklistGoal = new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4]), parts[0], int.Parse(parts[5]), int.Parse(parts[6]), int.Parse(parts[7]));
                    AddGoal(checklistGoal);
                    break;
            }
        }
    }

    public void SaveGoals()
    {
        ObtainFileName("Where would you like to save your goals? ");
        using (StreamWriter outputFile = new StreamWriter(_filename))
        {
            outputFile.WriteLine(_totalScore);
            // Write information to the file here
            foreach(BaseGoal goal in _goalList)
            {
                outputFile.WriteLine(goal.GetFileSystemString());
            }
        }
    }

    public void DisplayGoals()
    {
        // Create a FOR EACH loop that lists all the goals
        foreach (BaseGoal goal in _goalList)
        {
            Console.WriteLine(goal.GetConsoleString());
        }
    }

    public void RecordEvent()
    {
        Console.Write("Which goal did you accomplish? ");
        int goalNum = int.Parse(Console.ReadLine());
        BaseGoal goal = _goalList[goalNum - 1];

        if (!goal.GetCompletionStatus())
        {
            _totalScore += goal.RecordEvent();        
        }
        else
        {
            Console.WriteLine("That goal is already completed.");
        }

    }

    private void ObtainFileName(string prompt)
    {
        Console.Write(prompt);
        _filename = Console.ReadLine();
    }

}