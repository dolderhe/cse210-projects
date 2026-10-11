class Menu
{
    public int ProcessMenu()
    {
        int input = 0;

        while (input <1 || input > 6)
        {
            Console.WriteLine("Welcome to the Journal Program.");
            Console.WriteLine("Create, Display, Save, or Read Journal Entries.");
            Console.WriteLine("1. Create new journal entry.");
            Console.WriteLine("2. Display all Journal Entries.");
            Console.WriteLine("3. Load Journal.");
            Console.WriteLine("4. Save Journal.");
            Console.WriteLine("5. Clear Old Journal");
            Console.WriteLine("6. Quit");
            Console.Write("> ");
            
            input = int.Parse(Console.ReadLine());

            Console.WriteLine();                                                
        }
        return input;
    }
}