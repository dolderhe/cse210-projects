class Menu
{

    public Menu()
    {
    
    }

    public void DisplayMenu()
    {
        Console.WriteLine("Menu Options:\n  1. Create New Goal\n  2. List Goals\n  3. Save Goals\n  4. Load Goals\n  5. Record Event\n  6. Quit");

    }

    public void DisplayGoalMenu()
    {
        Console.Clear();
        Console.WriteLine("The types of Goals are:\n  1. Simple Goal\n  2. Eternal Goal\n  3. Checklist Goal");
    }
}