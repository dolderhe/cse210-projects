class Activity
{
    
    private int _duration;
    private DateTime _endTime;

    private string _activityName;
    private string _activityDescription;

    private string[] spinner = ["-", "\\", "|", "/"];
    private string[] face = ["(^_^)", "(-_-)"];
    private string[] fish = ["><))))o>", " ><))))o>"];
    private string[] timer = ["+", "-", "*"];

    /*Create Constructor*/
    public Activity(string activityName, string activityDescription)
    {
        _activityName = activityName;
        _activityDescription = activityDescription;
    }

    public void StartActivity()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_activityName}");
        Console.WriteLine($"\n{_activityDescription}\n");
        ObtainDuration();
        RunCountDownMessage("Get Ready", 5);
    }

    protected string[] GetAnimation(string animationName)
    {
        switch (animationName)
        {
            case "spinner":
                return spinner;
            case "face":
                return face;
            case "timer":
                return timer;
            case "fish":
                return fish;
            default:
                return spinner;
        }    
    }    
    public void EndActivity()
    {
        DisplaySpinnerMessage("Well Done!", 3, face);        
        DisplaySpinnerMessage($"You've completed another {_duration} seconds of the {_activityName}", 5, spinner);
    }

    /*TODO Display Timer*/
    public void StartTimer()
    {
        _endTime = DateTime.Now.AddSeconds(_duration);
    }

    public bool HasTimerExpired()
    {
        return DateTime.Now > _endTime;
    }

    public void RunCountDownMessage(string message, int seconds)
    {
        Console.CursorVisible = false;
        for(int i = seconds; i>=0; i--)
        {
            
            if (i == 0)
            {
                Console.Write($"\r{message}...   \r");
                Thread.Sleep(50);
            }
            else
            {
                Console.Write($"\r{message}... {i}\r");
                Thread.Sleep(1000);
            }
        
        }
        Console.CursorVisible = true;
    }

    /*TODO */
    public void DisplaySpinnerMessage(string message, int seconds, string[] animations)
    {
        Console.CursorVisible = false;

        Console.Write($"{message} ");
        DateTime endTime = DateTime.Now.AddSeconds(seconds);

        int index = 0;

        while(DateTime.Now < endTime)
        {
            string frame = animations[index++ % animations.Length];


            Console.Write(frame);
            Thread.Sleep(200);

            Console.Write(new string('\b', frame.Length));
            Console.Write(new string(' ', frame.Length));
            Console.Write(new string('\b', frame.Length));            
            
        }
        Console.WriteLine();
        Console.CursorVisible = true;
    }

    public void ObtainDuration()
    {
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
    }


}