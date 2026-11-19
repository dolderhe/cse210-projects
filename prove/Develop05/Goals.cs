class Goals
{
    private List<BaseGoal> _goalList;
    private string _filename;
    private int _totalScore;

    public Goals()
    {
        
    }

    public void DisplayScore()
    {
        Console.WriteLine($"You have {_totalScore} points.");
    }


}