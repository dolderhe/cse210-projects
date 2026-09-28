using System;

class Program
{
    
    static void Main(string[] args)
    {
        int input;
        
        List<int> numbers = new List<int>();
        
        do 
        {
        Console.Write("Enter Number: ");
        input = int.Parse(Console.ReadLine());
        
        if (input != 0){numbers.Add(input);}
        
        } while (input != 0);
        
        int sum = 0;
        int largestNumber = 0;
        int smallestNumber = 999999999;
        foreach (int number in numbers)
        {
            sum += number;
            if (number > largestNumber)
            {
                largestNumber = number;
            }
            if (number > 0)
            {
                if (number < smallestNumber)
                {
                    smallestNumber = number;
                }
            }
        }

        double avg = (double)sum / numbers.Count;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {avg}");
        Console.WriteLine($"The largest number is: {largestNumber}");
        Console.WriteLine($"The smallest number is: {smallestNumber}");
        
    }
}