using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment myAssignment = new Assignment("John Smith", "Math");

        Console.WriteLine(myAssignment.GetSummary());

    }
}