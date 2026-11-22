class Goals
{
    private List<BaseGoal> _goalList;
    private string _filename;
    private int _totalScore;
    private List<string> _filenameList = new List<string>();
    private List<BaseGoal> _completedGoals;

    public Goals()
    {
        _goalList = new List<BaseGoal>();
        _completedGoals = new List<BaseGoal>();

        LoadGoalList();
    }

    public void DisplayNames()
    {
        Console.Clear();
        int goal_number = 0;
        foreach (BaseGoal goal in _goalList)
        {
            goal_number ++;
            Console.WriteLine($"{goal_number}. {goal.GetName()}");
        }
    }

    public List<BaseGoal> GetGoalList()
    {
        return _goalList;
    }

    public List<BaseGoal> GetCompletedGoals()
    {
        return _completedGoals;
    }

    public void DisplayScore()
    {
        Console.WriteLine($"You have {_totalScore} points.");
    }

    public void AddGoal(BaseGoal Goal)
    {
        _goalList.Add(Goal);
    }

    public void LoadGoalList()
    {
    if (File.Exists("filenames"))
        {        
        string[] lines = System.IO.File.ReadAllLines("filenames");
            _filenameList.Clear();
            foreach(string line in lines)
            {
                _filenameList.Add(line);
            }
        }
    }

    public void SaveGoalList()
    {
    using (StreamWriter outputFile = new StreamWriter("filenames"))
        {
            foreach(string filename in _filenameList)
            {
                outputFile.WriteLine(filename);
            }
        }            

    }

    public void LoadGoals()
    {
        int count = 0;
        if(_filenameList.Count != 0)
        {
            Console.WriteLine("There are several files saved, which ones would you like to see?");

            foreach (string filename in _filenameList)
            {
                count ++;
                Console.WriteLine($"{count}. {filename}");
            }

            Console.Write("Which list of goals would you like to see? ");
            int file_index = int.Parse(Console.ReadLine());
            string[] lines = System.IO.File.ReadAllLines(_filenameList[file_index - 1]);

            _goalList.Clear();
            _completedGoals.Clear();

            _totalScore = int.Parse(lines[0]);

            for(int i = 1; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split(",");

                switch (parts[0])
                {
                    case "SimpleGoal":
                        SimpleGoal simpleGoal = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4]), parts[0]);
                        if (bool.Parse(parts[4]))
                        {
                            _completedGoals.Add(simpleGoal);
                        }
                        else
                        {
                            AddGoal(simpleGoal);                    
                        }
                        break;
                    case "EternalGoal":
                        EternalGoal eternalGoal = new EternalGoal(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4]), parts[0], int.Parse(parts[5]));
                        AddGoal(eternalGoal);                    
                        
                        break;
                    case "ChecklistGoal":
                        ChecklistGoal checklistGoal = new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4]), parts[0], int.Parse(parts[5]), int.Parse(parts[6]), int.Parse(parts[7]));
                        if (bool.Parse(parts[4]))
                        {
                            _completedGoals.Add(checklistGoal);
                        }
                        else
                        {
                            AddGoal(checklistGoal);
                        }
                        break;
                }
            }
        }    
    }

    public void SaveGoals()
    {
        ObtainFileName("Where would you like to save your goals? ");
        if (!_filenameList.Contains(_filename))
        {
        _filenameList.Add(_filename);
        }

        using (StreamWriter outputFile = new StreamWriter(_filename))
        {
            outputFile.WriteLine(_totalScore);
            // Write information to the file here
            foreach(BaseGoal goal in _goalList)
            {
                outputFile.WriteLine(goal.GetFileSystemString());
            }

            foreach (BaseGoal goal in _completedGoals)
            {
                outputFile.WriteLine(goal.GetFileSystemString());
            }

            
        }

        SaveGoalList();

    }

    public void DisplayGoals()
    {
        // Create a FOR EACH loop that lists all the goals
    Console.WriteLine("Here are your listed Goals:\n1. Active Goals\n2. Completed Goals");
    Console.Write("Which list would you like to look at? ");
    int input = int.Parse(Console.ReadLine());
    switch(input)
    {    
        case 1:
            foreach (BaseGoal goal in _goalList)
            {
                Console.WriteLine(goal.GetConsoleString());
            }
            break;
        case 2:
            foreach (BaseGoal goal in _completedGoals)
            {
                Console.WriteLine(goal.GetConsoleString());
            }
            break;
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

            if (goal.GetCompletionStatus())
            {   
                _completedGoals.Add(goal);
                _goalList.Remove(goal);
            }        
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