abstract class BaseGoal
{
    private string _name;
    private bool _completionStatus;
    private string _description;
    private int _points;
    private string _goalType;
    private string X;

    public BaseGoal(string name, string description, int point, bool completionStatus, string goalType)
    {
        _name = name;
        _description = description;
        _points = point;
        _completionStatus = completionStatus;
        _goalType = goalType;
        
    }
    public BaseGoal(string goalType)
    {
        SetName();
        SetDescription();
        SetPoint();
        _completionStatus = false;
        _goalType = goalType;
    }


    /*This method gets input from the user and set the variable _name to the user's input*/
    private void SetName()
    {
        Console.Write("Name of Goal: ");
        _name = Console.ReadLine();
    }

    private void SetDescription()
    {
        Console.Write($"What is the description of {_name} goal: ");
        _description = Console.ReadLine();
    }

    private void SetPoint()
    {
        Console.Write($"What are the points for {_name} goal: ");
        _points = int.Parse(Console.ReadLine());
    }

    public int GetPoint()
    {
        return _points;
    }

    public virtual string GetConsoleString()
    {
        X = " ";
        
        if (_completionStatus){
            X = "X";
        }
        
        return $"[{X}] Goal Name: {_name}\nDescription: {_description}\nPoints: {_points}\n";
    }

    public int MarkComplete()
    {
        _completionStatus = true;
        return _points;
    }

    public abstract int RecordEvent();

}