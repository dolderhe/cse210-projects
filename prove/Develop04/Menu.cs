class Menu
{
    /* Create Constructor */
    public Menu()
    {
        
    }
    /* Display Menu */
    public int DisplayMenu()
    {
        Console.WriteLine("Menu Options: ");
        Console.WriteLine("  1. Start Breathing Activity\n  2. Start Reflecting Activity\n  3. Start Listing Activity\n  4. Quit");
        Console.Write("Select a choice from the menu: ");
        return int.Parse(Console.ReadLine());
    }

}