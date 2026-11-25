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
    public Listing() : base("Listing Activity", "This activity will help you reflect on the good things in your life \nby having you list as many things as you can in a certain area.")
    {
        
    }
    /*TODO */

    public void RunActivity()
    {
        counter = 0;

        StartActivity();
        
        Console.WriteLine(_prompts[random.Next(_prompts.Count())]);
        StartTimer();


        while(!HasTimerExpired())
        {
            Console.Write(">");
            string response = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(response))
            {
                counter ++;
            }
        }

        Console.WriteLine($"You listed {counter} items!");    
        EndActivity();
        
    }
}