using System;

class Program
{
    static void Main(string[] args)
    {
        Menu myMenu = new Menu();

        Journal myJournal = new Journal();

        int response = 0;
        
        while(response != 5)
        {
            Console.WriteLine();
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
                    myJournal.ReadFromFile("journal.txt");
                    // Call ReadFromFile()
                    break;
                case 4:
                    myJournal.WriteToFile("journal.txt");
                    // call WriteToFile
                    break;
            }
        }
    }
}