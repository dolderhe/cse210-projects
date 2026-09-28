using System;

class Program 
{
    static void Main(string[] args)
    {
        // bool done;

        // do
        // {
        //     Console.Write("Are we done (y/n)? ");
        //     done = Console.ReadLine().ToLower() == "y";
        // } while (! done);
    
    for(double i = 0; i < 1; i+=2)
        {
            Console.WriteLine($"{i}");
        }
    
    List<string> myFriends = new List<string> {"bob", "betty", "Bubba"};

    myFriends.Add("Doug");

    foreach(string friend in myFriends)
        {
            Console.WriteLine(friend);
        }
    
    Console.Write("Enter Height:");
    string height = Console.ReadLine();
    int new_height = int.Parse(height);

    if(new_height > 78)
        {
            Console.WriteLine("Too tall");
        }
    else if (new_height < 48)
        {
            Console.WriteLine("Too Short");
        }
    else
        {
            Console.WriteLine("Just Right");
        }



    }


}