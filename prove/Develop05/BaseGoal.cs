class BaseGoal
{
    private string _name;
    private string _completionStatus;


    public BaseGoal()
    {
        SetName();
    }


    /*This method gets input from the user and set the variable _name to the user's input*/
    private void SetName()
    {
        Console.Write("Name of Goal: ");
        _name = Console.ReadLine();
    }

    public virtual string GetConsoleString()
    {
        return $"[{_completionStatus}] Goal Name: {_name}";
    }


}