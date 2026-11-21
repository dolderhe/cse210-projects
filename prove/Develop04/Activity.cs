class Activity
{
    
    private int _duration;
    private DateTime _endTime;

    private string _activityName;
    private string _activityDescription;

    /*Create Constructor*/
    public Activity()
    {
        Console.Clear();
    }

    public void StartActivity()
    {
        Console.WriteLine($"Welcome to the {SetName()}");
        Console.WriteLine($"\n{SetDescription()}\n");
        ObtainDuration();
        RunCountDownMessage("Get Ready", 5);
        StartTimer();
    }

    public string SetName()
    {
        return _activityName;
    }

    public void GetName(string activityName)
    {
        _activityName = activityName;
    }
    public string SetDescription()
    {
        return _activityDescription;
    }
    public void GetDescription(string activityDescription)
    {
        _activityDescription = activityDescription;
    }

    
    public void EndActivity()
    {
        DisplaySpinnerMessage($"Well Done. You've completed another {_duration} seconds of the {SetName()}", 2);
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
                Thread.Sleep(250);
            }
            else
            {
                Console.Write($"\r{message}... {i}\r");
                Thread.Sleep(1000);
            }
        
        }
        Console.CursorVisible = true;
    }

    public void RunSpinnerMessage(string message, int seconds)
    {
        Console.CursorVisible = false;
        // DateTime now = DateTime.Now;
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        // for(int i = 0; i < seconds; i++)
        while (DateTime.Now < endTime)
        {
            Console.Write("+");
            Thread.Sleep(200);
            Console.Write("\b");
            Console.Write("-");
            Thread.Sleep(200);
            Console.Write("\b");
            Console.Write("*");
            Thread.Sleep(200);
            Console.Write("\b");
        }
        Console.CursorVisible = true;
    }

    /*TODO */
    public void DisplaySpinnerMessage(string message, int seconds)
    {
        Console.CursorVisible = false;
        Console.Clear();
        Console.Write($"{message} ");
        DateTime endTime = DateTime.Now.AddSeconds(seconds);

        // for (int i=0; i < seconds; i++)
        while (DateTime.Now < endTime)
        {
            Console.Write("+");
            Thread.Sleep(200);
            Console.Write("\b");
            Console.Write("-");
            Thread.Sleep(200);
            Console.Write("\b");
        }

        Console.Clear();
       
        Console.Write($"{message} ");
        string spinnerAnimation = "-\\|/";
        int index = 0;
        for (int i=0; i<20; i++)
        {
            Console.Write($"{spinnerAnimation[index++ % spinnerAnimation.Length]}");
            Console.Write("\b");
            Thread.Sleep(300);
        }
        Console.Clear();

        Console.Write($"{message} ");
        string fishAnimation = "><))))o>";
        for (int i=0; i<20; i++)
        {
            Console.Write($" {fishAnimation}");
            Console.Write("\b\b\b\b\b\b\b\b");
            Thread.Sleep(300);
        }
        Console.Clear();

        Console.Write($"{message} ");
        string faceAnimation = "(^_^)(-_-)";
        for (int i=0; i<20; i++)
        {
            Console.Write($"{faceAnimation[0..5]}");
            Thread.Sleep(300);
            Console.Write("\b\b\b\b\b");
            Console.Write($"{faceAnimation[5..]}");
            Thread.Sleep(300);
            Console.Write("\b\b\b\b\b");
        }

        Console.CursorVisible = true;
    }

    public void ObtainDuration()
    {
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
    }


}