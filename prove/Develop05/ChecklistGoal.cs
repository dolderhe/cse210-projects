class ChecklistGoal : BaseGoal
{
    public ChecklistGoal(string name, string description, int points, bool completion, string goalType) : base(name, description, points, completion, goalType)
    {  
    }
    public ChecklistGoal(): base("ChecklistGoal")
    {  
    }

    public override int RecordEvent()
    {
        return 0;
    }
}