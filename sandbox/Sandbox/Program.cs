using System;

class Program
{
    /*
        int x;
        Console.Write("What is x? ");
        x = Console.ReadLine()
    */
    static void Main(string[] args)
    {
        int x = 8;
        
        if (x == 10 || x == 6)
        {
            Console.WriteLine("X is 10 or 6");
            Console.WriteLine("Y is fun");
        }
        else if (x == 9)
        {
            Console.WriteLine("X is 9");
        }
        else
        {
            Console.WriteLine($"X is {x}");
        }
    }
}