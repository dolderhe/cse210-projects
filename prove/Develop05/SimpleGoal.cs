class SimpleGoal : BaseGoal
{

    public SimpleGoal(string name, string description, int points, bool completion, string goalType) : base(name, description, points, completion, goalType)
    {
        
    }
    public SimpleGoal() : base("SimpleGoal")
    {
        
    }

    public override int RecordEvent()
    {
        MarkComplete();
        return GetPoints();
    }
}