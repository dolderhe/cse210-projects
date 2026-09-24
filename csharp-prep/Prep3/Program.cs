using System;

class Program
{
    static void Main(string[] args)
    {
        
        Random randomGenerator = new Random();
        int magic_number = randomGenerator.Next(1, 100);
        
        // Console.Write("What is the magic number? ");
        // int magic_number = int.Parse(Console.ReadLine());
        
        int guess;
        do
        {    
            Console.Write("What is your guess? ");
            string guess_str = Console.ReadLine();
            guess = int.Parse(guess_str);

            if (guess == magic_number)
            {
                Console.WriteLine("You guessed it!");
            }
            else if (guess > magic_number)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < magic_number)
            {
                Console.WriteLine("Higher");
            }
        } while (guess != magic_number);
    }
}