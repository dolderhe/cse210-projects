using System;

class Program
{
    static void Main(string[] args)
    {

        int choice = 1;
        int goalChoice = 1;

        Goals myGoals = new Goals();
        Menu myMenu = new Menu();

        while (choice != 6)
        {        
            myMenu.DisplayMenu();
            do
            {
            Console.Write("Select a choice from the menu: ");
            choice = int.Parse(Console.ReadLine());      
            } while(choice > 6 && choice < 1);

            switch (choice)
            {
                case 1:
                    myMenu.DisplayGoalMenu();
                    do
                    {
                    Console.Write("Which type of goal would you like to create? ");
                    goalChoice = int.Parse(Console.ReadLine());
                    } while(goalChoice > 3 && goalChoice < 1);
                    switch (goalChoice)
                    {
                        case 1:
                            Console.Clear();
                            SimpleGoal simpleGoal = new SimpleGoal();

                            break;
                        case 2:
                            Console.Clear();
                            EternalGoal eternalGoal = new EternalGoal();
                            break;
                        case 3:
                            Console.Clear();
                            ChecklistGoal checklistGoal = new ChecklistGoal();
                            break;
                    }
                    break;
                case 2:
                    Console.Write("List Goals");
                    Console.ReadLine();
                    break;
                case 3:
                    Console.Write("Save Goals");
                    Console.ReadLine();
                    break;
                case 4:
                    Console.Write("Load Goals");
                    Console.ReadLine();
                    break;
                case 5:
                    Console.Write("Record Event");
                    Console.ReadLine();
                    break;
            }
        }
    }
}