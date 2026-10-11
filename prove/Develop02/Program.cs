using System;

class Program
{
    static void Main(string[] args)
    {
        Menu myMenu = new Menu();

        Journal myJournal = new Journal();
        
        int counter = 0;
        int response = 0;
        
        while(response != 6)
        {
            if (counter > 0)
            {
                Console.WriteLine();
            }

            response = myMenu.ProcessMenu();
            switch (response)
            {
                case 1:
                    myJournal.CreateEntry();
                    break;
                case 2:
                    myJournal.DisplayJournal();
                    break;
                case 3:
                    Console.Write("What file holds your journal: (filename)\n> ");
                    myJournal.ReadFromFile(Console.ReadLine());
                    // Call ReadFromFile()
                    break;
                case 4:
                    Console.Write("Where would you like to save to: (filename)\n> ");
                    myJournal.WriteToFile(Console.ReadLine());
                    // call WriteToFile
                    break;
                case 5:
                    Console.Write("Which file would you like to delete: (filename)\n> ");
                    myJournal.ClearFile(Console.ReadLine());
                    break;
            
            }

            counter++;
        }
        myJournal.used_prompts.Clear();
    }
}