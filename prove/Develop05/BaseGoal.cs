class BaseGoal
{
    private string _name;
    private string _completionStatus = " ";
    private string _description;
    private int _points;


    public BaseGoal()
    {
        SetName();
        SetDescription();
        SetPoint();
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

    public virtual string GetConsoleString()
    {
        return $"[{_completionStatus}] Goal Name: {_name}\nDescription: {_description}\nPoints: {_points}\n";
    }

    public string MarkComplete()
    {
        _completionStatus = "X";
        return _completionStatus;
    }

}