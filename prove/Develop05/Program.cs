using System;

class Program
{
    static void Main(string[] args)
    {

        int choice = 1;
        int goalChoice = 1;

        Goals myGoals = new Goals();
        Menu myMenu = new Menu();
        Console.Clear();

        while (choice != 6)
        {        
            Console.WriteLine();
            myGoals.DisplayScore();
            Console.WriteLine();
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
                            myGoals.AddGoal(simpleGoal);
                            break;
                        case 2:
                            Console.Clear();
                            EternalGoal eternalGoal = new EternalGoal();
                            myGoals.AddGoal(eternalGoal);
                            break;
                        case 3:
                            Console.Clear();
                            ChecklistGoal checklistGoal = new ChecklistGoal();
                            myGoals.AddGoal(checklistGoal);
                            break;
                    }
                    break;
                case 2:
                    myGoals.DisplayGoals();
                    Console.Write("Press Enter to Continue: ");
                    Console.ReadLine();
                    break;
                case 3:
                    myGoals.DisplayNames();
                    myGoals.RecordEvent();
                    break;
                case 4:
                    myGoals.LoadGoals();
                    break;
                case 5:
                    myGoals.SaveGoals();
                    choice = 6;
                    break;

            }
        }
    }
}