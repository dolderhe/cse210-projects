using System;

class Program
{
    static void Main(string[] args)
    {
        Menu myMenu = new Menu();

        int choice = myMenu.DisplayMenu();

        while(choice != 4)
        {

            choice = myMenu.DisplayMenu();
            switch (choice)
            {
                case 1:
                    // 1Console.WriteLine("breath");
                    Breathing breathing = new Breathing();
                    breathing.RunActivity();
                    break;
                case 2:
                    Console.WriteLine("Reflect");                
                    // Reflecting reflecting = new Reflecting();
                    break;
                case 3:
                    Console.WriteLine("Listing");
                    // Listing listing = new Listing();
                    break;
                
            }
        }
    }
}