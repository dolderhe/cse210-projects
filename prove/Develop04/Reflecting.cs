class Reflecting : Activity
{
    private List<string> _prompts = [
        "Think of a time when you stood up for someone else: ",
        "Think of a time when you did something really difficult: ",
        "Think of a time when you helped someone in need: ",
        "Think of a time when you did something truly selfless: "
];
    private List<string> _followUps = [
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    ];
    private Random random = new Random();
    /*Create Constructor*/
    public Reflecting() : base()
    {
        
    }

    public void RunActivity()
    {

        GetName("Reflecting Activity");
        GetDescription("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        StartActivity();
        
        Console.Write(_prompts[random.Next(_prompts.Count())]);
        RunCountDownMessage("You may begin in: ", 5);
            
        while(! HasTimerExpired())  // Add when code is ready
        {
            
            Console.Write(_followUps[random.Next(_followUps.Count())]);
            Console.ReadLine();
            
        }

        EndActivity();

    }    

}