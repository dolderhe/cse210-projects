class Listing : Activity
{
    /*Create Constructor*/    
    private List<string> _prompts = [
    "Who are people that you appreciate? ",
    "What are personal strengths of yours?",
    "Who are people that you have helped this week? ",
    "When have you felt the Holy Ghost this month? ",
    "Who are some of your personal heroes? "
    ];

    int counter;
    Random random = new Random();
    public Listing() : base()
    {
        
    }
    /*TODO */

    public void RunActivity()
    {
        counter = 0;

        GetName("Listing Activity");
        GetDescription("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        StartActivity();
        
        Console.WriteLine(_prompts[random.Next(_prompts.Count())]);
        RunCountDownMessage("You may begin in: ", 5);
        


        while(!HasTimerExpired())
        {
            Console.Write(">");
            Console.ReadLine();
            counter ++;
        }

        Console.WriteLine($"You listed {counter} items!");    
        EndActivity();
        
    }
}