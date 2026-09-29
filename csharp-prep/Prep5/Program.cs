using System;

class Program
{
    static void Main(string[] args)
    {
        int x = 0;
        
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        PromptUserBirthYear(out x);
        DisplayResult(name, number, x);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string inputNumber = Console.ReadLine();
        int number = int.Parse(inputNumber);
        return number;
    }

    static void PromptUserBirthYear(out int birthYear)
    {
        Console.Write("Please enter the year you were born: ");
        string y = Console.ReadLine();
        birthYear = int.Parse(y);
    }

    static int SquareNumber(int x)
    {
       int squaredNumber = x * x;
       return squaredNumber;
    }

    static void DisplayResult(string name, int favoriteNumber, int birthYear)
    {
        Console.WriteLine($"{name}, the square of your number is {SquareNumber(favoriteNumber)}.");
        Console.WriteLine($"{name}, you will turn {2026 - birthYear} this year.");
    }
}