class EternalGoal : BaseGoal
{
    public EternalGoal(string name, string description, int points, bool completion, string goalType) : base(name, description, points, completion, goalType)
    {  
    }
    public EternalGoal(): base("EternalGoal")
    {  
    }

    public override int RecordEvent()
    {
        return 0;
    }

}