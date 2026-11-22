class EternalGoal : BaseGoal
{
    private int _timesCompleted;
    public EternalGoal(string name, string description, int points, bool completion, string goalType, int timesCompleted) : base(name, description, points, completion, goalType)
    {
        _timesCompleted = timesCompleted;
    }
    public EternalGoal(): base("EternalGoal")
    {  
    }

    public override int RecordEvent()
    {
        Console.Write("How many times did you complete this goal? ");
        _timesCompleted += int.Parse(Console.ReadLine());
        
        return GetPoints() * _timesCompleted;
    }

    public override string GetFileSystemString()
    {
        return $"{base.GetFileSystemString()},{_timesCompleted}";
    }

}