class Breathing : Activity
{
    /*Create Constructor*/
    /* TODO Breathing Timer (while loop (timer < timer)) */
    public Breathing(): base()
    {

    }

    public void RunActivity()
    {
        // call StartActivity() method
        

        Console.WriteLine("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
        StartActivity();
        // DateTime endTime = DateTime.Now.AddSeconds(20);  // delete later 
        // while (DateTime.Now < endTime)
        while(! HasTimerExpired())  // Add when code is ready
        {
            RunCountDownMessage("Breath in", 4);
            RunCountDownMessage("Breath Out", 6);
        }


        // CALL EndActivity()
        EndActivity();

    }
}