class ChecklistGoal : BaseGoal
{
    private int _timesCompleted;
    private int _numTimesGoal;
    private int _bonusPoints;
    public ChecklistGoal(string name, string description, int points, bool completion, string goalType, int timesCompleted, int numTimesGoal, int bonusPoints) : base(name, description, points, completion, goalType)
    {
        _timesCompleted = timesCompleted;
        _numTimesGoal = numTimesGoal;
        _bonusPoints = bonusPoints;
    }
    public ChecklistGoal(): base("ChecklistGoal")
    {
        SetCompletionGoal();   
    }


    public void SetCompletionGoal()
    {
        Console.Write("How many times would you like to do this? ");
        _numTimesGoal = int.Parse(Console.ReadLine());
        Console.Write("How many extra points do you get if you finish? ");
        _bonusPoints = int.Parse(Console.ReadLine());
    }
    public override string GetConsoleString()
    {
        int points = GetPoints();
        string name = GetName();
        string description = GetDescription();
        string X = " ";

        if (GetCompletionStatus()){
            X = "X";
        }

        if (_timesCompleted >= _numTimesGoal)
        {
            _timesCompleted = _numTimesGoal;
        }

        return $"[{X}] Goal Name: {name}\nDescription: {description}\nPoints: {points}\nCurrently Completed: {_timesCompleted}/{_numTimesGoal}";
    }
    public override int RecordEvent()
    {
        int prevTimesCompleted = _timesCompleted;
        
        Console.Write("How many times have you completed this goal? ");
        
        int tempTimesCompleted = int.Parse(Console.ReadLine());

        _timesCompleted += tempTimesCompleted;

        if (_timesCompleted >= _numTimesGoal)
        {
            MarkComplete();

            tempTimesCompleted = _numTimesGoal - prevTimesCompleted;

            return (GetPoints() * tempTimesCompleted) + _bonusPoints;
        }

        return GetPoints() * tempTimesCompleted;
    }

    public override string GetFileSystemString()
    {
        return $"{base.GetFileSystemString()},{_timesCompleted},{_numTimesGoal},{_bonusPoints}";
    }
}