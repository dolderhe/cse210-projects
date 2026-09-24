using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        
        string gradeString;
        Console.Write("What was your grade percentage? ");
        gradeString = Console.ReadLine();
        int gradeInt = int.Parse(gradeString);

        if (gradeInt % 10 >= 7 !&& gradeInt/10 > 10)
        {
            string gradeSign = "+";
        }
        else if (gradeInt % 10 < 3 !&& gradeInt/10 > 10)
        {
            
        }

        if (gradeInt >= 90)
        {
            Console.WriteLine("Amazing job, you got an A!");
        }
        else if (gradeInt >= 80)
        {
            Console.WriteLine("Great job, you got a B!");
        }
        else if (gradeInt >= 70)
        {
            Console.WriteLine("Good job, you got a C!");
        }        
        else if (gradeInt >= 60)
        {
            Console.WriteLine("You aren't a high achiever but I guess it could have been worse, you got a D.");
        }
        else if (gradeInt < 60)
        {
            Console.WriteLine("You got an F, you failed");
        }


        if (gradeInt >= 70)
        {
            Console.WriteLine("You passed the class!");
        }
        else
        {
            Console.WriteLine("You didn't make it this time, better luck next time");
        }
    }
}