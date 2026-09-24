using System;

class Program
{
    static void Main(string[] args)
    {
        

        // Console.Write("What is the magic number? ");
        // int magic_number = int.Parse(Console.ReadLine());
        
        int guess;
        string play_again;
        do
        {
        Random randomGenerator = new Random();
        int magic_number = randomGenerator.Next(1, 100);
        int x = 0;
        do
        {    
            Console.Write("\nWhat is your guess? ");
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
            x++;
        } while (guess != magic_number);
            Console.WriteLine($"It took you {x} tries.");
            Console.Write("Would you like to play again? ");            
            play_again = Console.ReadLine();
        } while (play_again == "yes");
    }
}